namespace Website
{
    partial class frmLoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginPage));
            txtUserName = new TextBox();
            lblUserName = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.White;
            txtUserName.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.Black;
            txtUserName.Location = new Point(201, 175);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(150, 31);
            txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblUserName.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.White;
            lblUserName.Location = new Point(51, 178);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(127, 23);
            lblUserName.TabIndex = 4;
            lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblPassword.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(51, 247);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(113, 23);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(201, 244);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Red;
            btnLogin.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(163, 316);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(92, 40);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Blue;
            label1.Location = new Point(0, -1);
            label1.Name = "label1";
            label1.Size = new Size(427, 108);
            label1.TabIndex = 9;
            // 
            // label3
            // 
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(148, 9);
            label3.Name = "label3";
            label3.Size = new Size(230, 79);
            label3.TabIndex = 10;
            label3.Text = "TECH SPECTRUM";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Georgia", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 79);
            label2.TabIndex = 11;
            label2.Text = "🌐";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmLoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(427, 388);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Controls.Add(txtUserName);
            MinimizeBox = false;
            Name = "frmLoginPage";
            Text = "frmLoginPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label3;
    }
}