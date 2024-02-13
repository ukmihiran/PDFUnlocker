using GroupDocs.Merger;
using GroupDocs.Merger.Domain.Options;
using iText.Kernel.Exceptions;
using iText.Kernel.Pdf;
using System.Runtime.InteropServices;

namespace PDFUnlocker
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            Panel1.MouseDown += Panel1_MouseDown;
            Panel1.MouseMove += Panel1_MouseMove;

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [LibraryImport("user32.dll")]
        public static partial int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [LibraryImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static partial bool ReleaseCapture();

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void Panel1_MouseDown(object? sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Panel1_MouseMove(object? sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAddFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in openFileDialog.FileNames)
                {
                    FileInfo fileInfo = new(filename);
                    DataGridView1.Rows.Add(filename, fileInfo.Length / 1024, IsPdfProtected(filename));
                }
            }
        }
        private bool IsPdfProtected(string filename)
        {
            try
            {
                PdfReader pdfReader = new(filename);
                PdfDocument pdfDocument = new(pdfReader); 

                
                return false;
            }
            catch (BadPasswordException)
            {
                return true;
            }
            catch (IOException)
            {
                // Handle file errors
                return false;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.Clear();
        }

        private void BtnRemovePassword_Click(object sender, EventArgs e)
        {
            if (DataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a PDF file.");
                return;
            }

            
            string password = GetPasswordFromUser(); // Get the password from the user  

            foreach (DataGridViewRow row in DataGridView1.SelectedRows)
            {
                string? filePath = row.Cells[0].Value.ToString(); // Assuming file path is in the 1st column

                // Perform password removal and saving for each filePath here
                RemovePasswordAndSave(filePath!, password);
            }
        }

        private void RemovePasswordAndSave(string filePath, string password)
        {
            try
            {
                if (filePath == null)
                {
                    throw new ArgumentNullException(nameof(filePath), "File path cannot be null.");
                }

                if (password == null)
                {
                    throw new ArgumentNullException(nameof(password), "Password cannot be null.");
                }

                //PDF gets a unique filename
                string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
                string guidSubstring = Guid.NewGuid().ToString()[..8]; // Take a portion of the GUID
                string newFilename = Path.GetFileNameWithoutExtension(filePath) + "_unlocked_" + timestamp + "_" + guidSubstring + ".pdf";
                string outputPath = Path.Combine(Path.GetDirectoryName(filePath)!, newFilename);

                LoadOptions loadOptions = new(password);
                using (Merger merger = new(filePath, loadOptions))
                {
                    merger.RemovePassword();
                    merger.Save(outputPath);
                }
                {
                    // All security is removed at this point
                }

                MessageBox.Show("Password removed successfully!");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            catch (BadPasswordException)
            {
                MessageBox.Show("Error: Incorrect password.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error accessing files: " + ex.Message);
            }
            catch (Exception ex) // General fallback
            {
                MessageBox.Show("Error removing password: " + ex.Message);
            }
        }

        private static string GetPasswordFromUser()
        {
            using var passwordDialog = new PasswordInputDialog();
            if (passwordDialog.ShowDialog() == DialogResult.OK)
            {
                return passwordDialog.EnteredPassword;
            }
            else
            {
                return null!; // User canceled
            }
        }
    }
}
