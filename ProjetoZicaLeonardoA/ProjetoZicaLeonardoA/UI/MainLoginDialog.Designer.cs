namespace ProjetoZicaLeonardoA
{
    partial class MainLoginDialog
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
            this.LabelUserLogin = new MetroFramework.Controls.MetroLabel();
            this.LabelPasswordLogin = new MetroFramework.Controls.MetroLabel();
            this.txtUser = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.BtnloginCancel = new MetroFramework.Controls.MetroButton();
            this.BtnLoginOK = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // LabelUserLogin
            // 
            this.LabelUserLogin.AutoSize = true;
            this.LabelUserLogin.Location = new System.Drawing.Point(58, 131);
            this.LabelUserLogin.Name = "LabelUserLogin";
            this.LabelUserLogin.Size = new System.Drawing.Size(56, 19);
            this.LabelUserLogin.TabIndex = 0;
            this.LabelUserLogin.Text = "Usuário:";
            // 
            // LabelPasswordLogin
            // 
            this.LabelPasswordLogin.AutoSize = true;
            this.LabelPasswordLogin.Location = new System.Drawing.Point(64, 171);
            this.LabelPasswordLogin.Name = "LabelPasswordLogin";
            this.LabelPasswordLogin.Size = new System.Drawing.Size(47, 19);
            this.LabelPasswordLogin.TabIndex = 1;
            this.LabelPasswordLogin.Text = "Senha:";
            // 
            // txtUser
            // 
            // 
            // 
            // 
            this.txtUser.CustomButton.Image = null;
            this.txtUser.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtUser.CustomButton.Name = "";
            this.txtUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUser.CustomButton.TabIndex = 1;
            this.txtUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUser.CustomButton.UseSelectable = true;
            this.txtUser.CustomButton.Visible = false;
            this.txtUser.Lines = new string[0];
            this.txtUser.Location = new System.Drawing.Point(118, 129);
            this.txtUser.MaxLength = 32767;
            this.txtUser.Name = "txtUser";
            this.txtUser.PasswordChar = '\0';
            this.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUser.SelectedText = "";
            this.txtUser.SelectionLength = 0;
            this.txtUser.SelectionStart = 0;
            this.txtUser.ShortcutsEnabled = true;
            this.txtUser.Size = new System.Drawing.Size(137, 23);
            this.txtUser.TabIndex = 2;
            this.txtUser.UseSelectable = true;
            this.txtUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.IconRight = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(118, 169);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(137, 23);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BtnloginCancel
            // 
            this.BtnloginCancel.Location = new System.Drawing.Point(64, 240);
            this.BtnloginCancel.Name = "BtnloginCancel";
            this.BtnloginCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnloginCancel.TabIndex = 4;
            this.BtnloginCancel.Text = "Cancelar";
            this.BtnloginCancel.UseSelectable = true;
            // 
            // BtnLoginOK
            // 
            this.BtnLoginOK.Location = new System.Drawing.Point(180, 240);
            this.BtnLoginOK.Name = "BtnLoginOK";
            this.BtnLoginOK.Size = new System.Drawing.Size(75, 23);
            this.BtnLoginOK.TabIndex = 5;
            this.BtnLoginOK.Text = "Ok";
            this.BtnLoginOK.UseSelectable = true;
            this.BtnLoginOK.Click += new System.EventHandler(this.BtnLoginOK_Click);
            // 
            // MainLoginDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.BtnLoginOK);
            this.Controls.Add(this.BtnloginCancel);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.LabelPasswordLogin);
            this.Controls.Add(this.LabelUserLogin);
            this.KeyPreview = true;
            this.Name = "MainLoginDialog";
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManterCliente_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LabelUserLogin;
        private MetroFramework.Controls.MetroLabel LabelPasswordLogin;
        private MetroFramework.Controls.MetroTextBox txtUser;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton BtnloginCancel;
        private MetroFramework.Controls.MetroButton BtnLoginOK;
    }
}

