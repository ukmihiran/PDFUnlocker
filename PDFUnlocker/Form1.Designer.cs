namespace PDFUnlocker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Panel1 = new Panel();
            Lbl1Banner = new Label();
            BtnClose = new Button();
            panel2 = new Panel();
            BtnRemovePassword = new Button();
            BtnClear = new Button();
            BtnAddFile = new Button();
            DataGridView1 = new DataGridView();
            FilePath = new DataGridViewTextBoxColumn();
            Size = new DataGridViewTextBoxColumn();
            Protected = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            Panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.AllowDrop = true;
            Panel1.BackColor = SystemColors.ActiveCaptionText;
            Panel1.Controls.Add(Lbl1Banner);
            Panel1.Controls.Add(BtnClose);
            Panel1.Dock = DockStyle.Top;
            Panel1.Location = new Point(0, 0);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(973, 37);
            Panel1.TabIndex = 0;
            Panel1.MouseDown += Panel1_MouseDown;
            Panel1.MouseMove += Panel1_MouseMove;
            Panel1.MouseUp += Panel1_MouseUp;
            // 
            // Lbl1Banner
            // 
            Lbl1Banner.AutoSize = true;
            Lbl1Banner.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lbl1Banner.ForeColor = Color.White;
            Lbl1Banner.Location = new Point(12, 9);
            Lbl1Banner.Name = "Lbl1Banner";
            Lbl1Banner.Size = new Size(170, 20);
            Lbl1Banner.TabIndex = 1;
            Lbl1Banner.Text = "PDF Password Remover";
            // 
            // BtnClose
            // 
            BtnClose.BackgroundImage = (Image)resources.GetObject("BtnClose.BackgroundImage");
            BtnClose.BackgroundImageLayout = ImageLayout.Center;
            BtnClose.Dock = DockStyle.Right;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.Location = new Point(921, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(52, 37);
            BtnClose.TabIndex = 0;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GrayText;
            panel2.Controls.Add(BtnRemovePassword);
            panel2.Controls.Add(BtnClear);
            panel2.Controls.Add(BtnAddFile);
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(973, 107);
            panel2.TabIndex = 1;
            // 
            // BtnRemovePassword
            // 
            BtnRemovePassword.BackColor = Color.FromArgb(239, 65, 77);
            BtnRemovePassword.FlatAppearance.BorderSize = 0;
            BtnRemovePassword.FlatStyle = FlatStyle.Flat;
            BtnRemovePassword.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRemovePassword.Image = (Image)resources.GetObject("BtnRemovePassword.Image");
            BtnRemovePassword.Location = new Point(467, 27);
            BtnRemovePassword.Name = "BtnRemovePassword";
            BtnRemovePassword.Size = new Size(200, 56);
            BtnRemovePassword.TabIndex = 4;
            BtnRemovePassword.Text = "Remove Password";
            BtnRemovePassword.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnRemovePassword.UseVisualStyleBackColor = false;
            BtnRemovePassword.Click += BtnRemovePassword_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(49, 81, 149);
            BtnClear.FlatAppearance.BorderSize = 0;
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.ForeColor = Color.White;
            BtnClear.Image = (Image)resources.GetObject("BtnClear.Image");
            BtnClear.Location = new Point(250, 27);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(181, 56);
            BtnClear.TabIndex = 3;
            BtnClear.Text = "Clear All";
            BtnClear.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnAddFile
            // 
            BtnAddFile.BackColor = Color.FromArgb(49, 81, 149);
            BtnAddFile.FlatAppearance.BorderSize = 0;
            BtnAddFile.FlatStyle = FlatStyle.Flat;
            BtnAddFile.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAddFile.ForeColor = Color.White;
            BtnAddFile.Image = (Image)resources.GetObject("BtnAddFile.Image");
            BtnAddFile.Location = new Point(29, 27);
            BtnAddFile.Name = "BtnAddFile";
            BtnAddFile.Size = new Size(178, 56);
            BtnAddFile.TabIndex = 2;
            BtnAddFile.Text = "Import PDF";
            BtnAddFile.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAddFile.UseVisualStyleBackColor = false;
            BtnAddFile.Click += BtnAddFile_Click;
            // 
            // DataGridView1
            // 
            DataGridView1.AccessibleRole = AccessibleRole.Row;
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.AllowUserToDeleteRows = false;
            DataGridView1.AllowUserToOrderColumns = true;
            DataGridView1.AllowUserToResizeRows = false;
            DataGridView1.BackgroundColor = SystemColors.ControlLight;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { FilePath, Size, Protected });
            DataGridView1.Location = new Point(29, 162);
            DataGridView1.MultiSelect = false;
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            DataGridView1.Size = new Size(918, 482);
            DataGridView1.TabIndex = 2;
            DataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FilePath
            // 
            FilePath.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            FilePath.Frozen = true;
            FilePath.HeaderText = "File Path";
            FilePath.Name = "FilePath";
            FilePath.ReadOnly = true;
            FilePath.Resizable = DataGridViewTriState.False;
            FilePath.SortMode = DataGridViewColumnSortMode.Programmatic;
            FilePath.Width = 675;
            // 
            // Size
            // 
            Size.HeaderText = "File Size (KB)";
            Size.Name = "Size";
            Size.ReadOnly = true;
            // 
            // Protected
            // 
            Protected.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Protected.HeaderText = "Password Protected";
            Protected.Name = "Protected";
            Protected.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(29, 668);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 3;
            label1.Text = "Dev By ~ Ukmihiran";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 684);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 4;
            label2.Text = "Version - 1.0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(973, 724);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DataGridView1);
            Controls.Add(panel2);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Panel1;
        private Button BtnClose;
        private Panel panel2;
        private Button BtnAddFile;
        private Button BtnRemovePassword;
        private Button BtnClear;
        private Label Lbl1Banner;
        private DataGridView DataGridView1;
        private DataGridViewTextBoxColumn FilePath;
        private new DataGridViewTextBoxColumn Size;
        private DataGridViewTextBoxColumn Protected;
        private Label label1;
        private Label label2;
    }
}
