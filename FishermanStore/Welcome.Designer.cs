namespace FishermanStore
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            button_login = new Button();
            button_register = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(390, 119);
            label1.Name = "label1";
            label1.Size = new Size(525, 50);
            label1.TabIndex = 0;
            label1.Text = "Welcom to Fishermen's Store";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(372, 284);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 1;
            label2.Text = "User name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(375, 342);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(554, 286);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(272, 35);
            txt_username.TabIndex = 3;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(553, 344);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(273, 35);
            txt_password.TabIndex = 4;
            // 
            // button_login
            // 
            button_login.Location = new Point(695, 404);
            button_login.Name = "button_login";
            button_login.Size = new Size(131, 61);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_register
            // 
            button_register.Location = new Point(553, 404);
            button_register.Name = "button_register";
            button_register.Size = new Size(131, 61);
            button_register.TabIndex = 7;
            button_register.Text = "Register";
            button_register.UseVisualStyleBackColor = true;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 671);
            Controls.Add(button_register);
            Controls.Add(button_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Welcome";
            Text = "Welcome";
            Load += Welcome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button button_login;
        private Button button_register;
    }
}