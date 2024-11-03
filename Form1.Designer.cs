namespace test_user_login_con_db
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            txt_pw = new Guna.UI2.WinForms.Guna2TextBox();
            btn_login = new Guna.UI2.WinForms.Guna2Button();
            btn_exit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._149071;
            pictureBox1.Location = new Point(107, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Bauhaus 93", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(107, 173);
            label1.Name = "label1";
            label1.Size = new Size(140, 35);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_username
            // 
            txt_username.BorderRadius = 20;
            txt_username.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            txt_username.CustomizableEdges = customizableEdges1;
            txt_username.DefaultText = "";
            txt_username.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_username.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_username.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_username.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_username.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_username.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_username.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_username.Location = new Point(41, 228);
            txt_username.Margin = new Padding(4, 5, 4, 5);
            txt_username.Name = "txt_username";
            txt_username.PasswordChar = '\0';
            txt_username.PlaceholderForeColor = Color.Silver;
            txt_username.PlaceholderText = "Username";
            txt_username.SelectedText = "";
            txt_username.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txt_username.Size = new Size(285, 49);
            txt_username.TabIndex = 2;
            // 
            // txt_pw
            // 
            txt_pw.BorderRadius = 20;
            txt_pw.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            txt_pw.CustomizableEdges = customizableEdges3;
            txt_pw.DefaultText = "";
            txt_pw.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txt_pw.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txt_pw.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txt_pw.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txt_pw.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_pw.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txt_pw.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txt_pw.Location = new Point(41, 297);
            txt_pw.Margin = new Padding(4, 5, 4, 5);
            txt_pw.Name = "txt_pw";
            txt_pw.PasswordChar = '\0';
            txt_pw.PlaceholderForeColor = Color.Silver;
            txt_pw.PlaceholderText = "Password";
            txt_pw.SelectedText = "";
            txt_pw.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txt_pw.Size = new Size(285, 49);
            txt_pw.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.BorderRadius = 10;
            btn_login.Cursor = Cursors.Hand;
            btn_login.CustomizableEdges = customizableEdges5;
            btn_login.DisabledState.BorderColor = Color.DarkGray;
            btn_login.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_login.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_login.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_login.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(41, 395);
            btn_login.Name = "btn_login";
            btn_login.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_login.Size = new Size(129, 44);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.Click += btn_login_Click;
            // 
            // btn_exit
            // 
            btn_exit.BorderRadius = 10;
            btn_exit.Cursor = Cursors.Hand;
            btn_exit.CustomizableEdges = customizableEdges7;
            btn_exit.DisabledState.BorderColor = Color.DarkGray;
            btn_exit.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_exit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_exit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_exit.FillColor = Color.Red;
            btn_exit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(197, 395);
            btn_exit.Name = "btn_exit";
            btn_exit.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_exit.Size = new Size(129, 44);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.Click += btn_exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(376, 515);
            Controls.Add(btn_exit);
            Controls.Add(btn_login);
            Controls.Add(txt_pw);
            Controls.Add(txt_username);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_pw;
        private Guna.UI2.WinForms.Guna2Button btn_login;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
    }
}
