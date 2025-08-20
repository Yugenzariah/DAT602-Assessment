namespace Login_and_Registration
{
    partial class LoginForm
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
            title = new Label();
            usernameLbl = new Label();
            passwordLbl = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Comic Sans MS", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(183, 9);
            title.Name = "title";
            title.Size = new Size(393, 112);
            title.TabIndex = 0;
            title.Text = "The Raze";
            // 
            // usernameLbl
            // 
            usernameLbl.AutoSize = true;
            usernameLbl.BackColor = Color.Transparent;
            usernameLbl.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLbl.ForeColor = Color.White;
            usernameLbl.Location = new Point(95, 151);
            usernameLbl.Name = "usernameLbl";
            usernameLbl.Size = new Size(212, 51);
            usernameLbl.TabIndex = 1;
            usernameLbl.Text = "Username:";
            // 
            // passwordLbl
            // 
            passwordLbl.AutoSize = true;
            passwordLbl.BackColor = Color.Transparent;
            passwordLbl.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLbl.ForeColor = Color.White;
            passwordLbl.Location = new Point(108, 229);
            passwordLbl.Name = "passwordLbl";
            passwordLbl.Size = new Size(199, 51);
            passwordLbl.TabIndex = 2;
            passwordLbl.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(293, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(293, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 27);
            textBox2.TabIndex = 4;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._86973_3840x2160_desktop_4k_post_apocalypse_wallpaper_image;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(passwordLbl);
            Controls.Add(usernameLbl);
            Controls.Add(title);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label usernameLbl;
        private Label passwordLbl;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}