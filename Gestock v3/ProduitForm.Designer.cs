namespace Gestock_v3
{
    partial class ProduitForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(189, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 31);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(189, 323);
            button1.Name = "button1";
            button1.Size = new Size(203, 34);
            button1.TabIndex = 2;
            button1.Text = "Ajouter le produit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(189, 243);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 31);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 121);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 4;
            label1.Text = "Nom du produit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 185);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 5;
            label2.Text = "Prix du produit";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 243);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 6;
            label3.Text = "Quantité";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(189, 55);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 7;
            label4.Text = "Ajouter un produit";
            // 
            // ProduitForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "ProduitForm";
            Text = "ProduitForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}