namespace PDFUnlocker
{
    partial class PasswordInputDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Lbl1TxtPass = new Label();
            TxtPassword = new TextBox();
            BtnOK = new Button();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // Lbl1TxtPass
            // 
            Lbl1TxtPass.AutoSize = true;
            Lbl1TxtPass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lbl1TxtPass.ForeColor = Color.White;
            Lbl1TxtPass.Location = new Point(29, 51);
            Lbl1TxtPass.Name = "Lbl1TxtPass";
            Lbl1TxtPass.Size = new Size(155, 21);
            Lbl1TxtPass.TabIndex = 0;
            Lbl1TxtPass.Text = "Enter PDF Password :";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(190, 51);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(304, 23);
            TxtPassword.TabIndex = 1;
            TxtPassword.TextChanged += textBox1_TextChanged;
            // 
            // BtnOK
            // 
            BtnOK.BackColor = Color.FromArgb(49, 81, 149);
            BtnOK.DialogResult = DialogResult.OK;
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.Location = new Point(190, 108);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(102, 34);
            BtnOK.TabIndex = 2;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.FromArgb(49, 81, 149);
            BtnCancel.DialogResult = DialogResult.Cancel;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Location = new Point(321, 108);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(102, 34);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // PasswordInputDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(553, 166);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOK);
            Controls.Add(TxtPassword);
            Controls.Add(Lbl1TxtPass);
            Name = "PasswordInputDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl1TxtPass;
        private TextBox TxtPassword;
        private Button BtnOK;
        private Button BtnCancel;
    }
}