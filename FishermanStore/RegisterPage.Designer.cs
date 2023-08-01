namespace FishermanStore
{
    partial class RegisterPage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_username_register = new TextBox();
            txt_password_register = new TextBox();
            txt_confirm = new TextBox();
            btn_register = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(216, 56);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 45);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(216, 152);
            label2.Name = "label2";
            label2.Size = new Size(115, 30);
            label2.TabIndex = 1;
            label2.Text = "User name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(216, 223);
            label3.Name = "label3";
            label3.Size = new Size(103, 30);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(214, 295);
            label4.Name = "label4";
            label4.Size = new Size(186, 30);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            label4.Click += label4_Click;
            // 
            // txt_username_register
            // 
            txt_username_register.Location = new Point(216, 185);
            txt_username_register.Name = "txt_username_register";
            txt_username_register.Size = new Size(325, 35);
            txt_username_register.TabIndex = 4;
            // 
            // txt_password_register
            // 
            txt_password_register.Location = new Point(215, 257);
            txt_password_register.Name = "txt_password_register";
            txt_password_register.Size = new Size(326, 35);
            txt_password_register.TabIndex = 5;
            // 
            // txt_confirm
            // 
            txt_confirm.Location = new Point(216, 328);
            txt_confirm.Name = "txt_confirm";
            txt_confirm.Size = new Size(322, 35);
            txt_confirm.TabIndex = 6;
            txt_confirm.TextChanged += txt_confirm_TextChanged;
            // 
            // btn_register
            // 
            btn_register.Location = new Point(220, 405);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(321, 52);
            btn_register.TabIndex = 7;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = true;
            btn_register.Click += btn_register_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(229, 480);
            label5.Name = "label5";
            label5.Size = new Size(257, 30);
            label5.TabIndex = 8;
            label5.Text = "Already have an account?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(270, 522);
            label6.Name = "label6";
            label6.Size = new Size(152, 30);
            label6.TabIndex = 9;
            label6.Text = "Back to LOGIN";
            // 
            // RegisterPage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 671);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btn_register);
            Controls.Add(txt_confirm);
            Controls.Add(txt_password_register);
            Controls.Add(txt_username_register);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "RegisterPage";
            Text = "RegisterPage";
            Load += RegisterPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_username_register;
        private TextBox txt_password_register;
        private TextBox txt_confirm;
        private Button btn_register;
        private Label label5;
        private Label label6;
    }
}