namespace Website
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Blue;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(460, 108);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.BackColor = Color.Blue;
            label2.Font = new Font("Georgia", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(43, 9);
            label2.Name = "label2";
            label2.Size = new Size(109, 79);
            label2.TabIndex = 4;
            label2.Text = "🌐";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Blue;
            label3.Font = new Font("Georgia", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(158, 9);
            label3.Name = "label3";
            label3.Size = new Size(230, 79);
            label3.TabIndex = 5;
            label3.Text = "TECH SPECTRUM";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(459, 364);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimizeBox = false;
            Name = "SignUp";
            Text = "SignUp";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}