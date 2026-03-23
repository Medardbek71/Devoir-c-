namespace Gestok
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
            login = new Button();
            password = new TextBox();
            username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // login
            // 
            login.Location = new Point(259, 267);
            login.Name = "login";
            login.Size = new Size(258, 54);
            login.TabIndex = 0;
            login.Text = "Connexion";
            login.UseVisualStyleBackColor = true;
            login.Click += button1_Click;
            // 
            // password
            // 
            password.Location = new Point(259, 198);
            password.Name = "password";
            password.Size = new Size(258, 31);
            password.UseSystemPasswordChar = true;
            password.TabIndex = 1;
            // 
            // username
            // 
            username.Location = new Point(259, 117);
            username.Name = "username";
            username.Size = new Size(258, 31);
            username.TabIndex = 2;
            username.TextChanged += username_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 124);
            label1.Name = "label1";
            label1.Size = new Size(148, 25);
            label1.TabIndex = 3;
            label1.Text = "Nom d'utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 204);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 4;
            label2.Text = "Mot de passe";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(username);
            Controls.Add(password);
            Controls.Add(login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private TextBox password;
        private TextBox username;
        private Label label1;
        private Label label2;
    }
}
