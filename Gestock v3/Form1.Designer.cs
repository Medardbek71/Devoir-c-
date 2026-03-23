namespace Gestock_v3
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
            button1 = new Button();
            motDePasse = new TextBox();
            nomUtilisateur = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(276, 319);
            button1.Name = "button1";
            button1.Size = new Size(293, 43);
            button1.TabIndex = 0;
            button1.Text = "Connexion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // motDePasse
            // 
            motDePasse.Location = new Point(276, 251);
            motDePasse.Name = "motDePasse";
            motDePasse.Size = new Size(293, 31);
            motDePasse.TabIndex = 1;
            motDePasse.TextChanged += textBox1_TextChanged;
            // 
            // nomUtilisateur
            // 
            nomUtilisateur.Location = new Point(276, 191);
            nomUtilisateur.Name = "nomUtilisateur";
            nomUtilisateur.Size = new Size(293, 31);
            nomUtilisateur.TabIndex = 2;
            nomUtilisateur.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 194);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 3;
            label1.Text = "Nom d'utilisateur:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 254);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 4;
            label2.Text = "Mot de passe:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nomUtilisateur);
            Controls.Add(motDePasse);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox motDePasse;
        private TextBox nomUtilisateur;
        private Label label1;
        private Label label2;
    }
}
