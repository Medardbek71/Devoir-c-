namespace Gestock_v3
{
    partial class mainScreen
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
            AddButton = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            Nom = new DataGridViewTextBoxColumn();
            Prix = new DataGridViewTextBoxColumn();
            Quantité = new DataGridViewTextBoxColumn();
            Statut = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            Supprimer = new DataGridViewButtonColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(810, 44);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(190, 42);
            AddButton.TabIndex = 0;
            AddButton.Text = "Ajouter un article";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 44);
            label1.Name = "label1";
            label1.Size = new Size(189, 25);
            label1.TabIndex = 1;
            label1.Text = "Bienvenue sur Gestock";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(23, 92);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1195, 453);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1187, 415);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nom, Prix, Quantité, Statut, Action, Supprimer });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1181, 409);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1187, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Nom
            // 
            Nom.HeaderText = "Nom du produit";
            Nom.MinimumWidth = 8;
            Nom.Name = "Nom";
            Nom.Width = 150;
            // 
            // Prix
            // 
            Prix.HeaderText = "Prix";
            Prix.MinimumWidth = 8;
            Prix.Name = "Prix";
            Prix.Width = 150;
            // 
            // Quantité
            // 
            Quantité.HeaderText = "Quantité";
            Quantité.MinimumWidth = 8;
            Quantité.Name = "Quantité";
            Quantité.Width = 150;
            // 
            // Statut
            // 
            Statut.HeaderText = "Statut";
            Statut.MinimumWidth = 8;
            Statut.Name = "Statut";
            Statut.Width = 150;
            // 
            // Action
            // 
            Action.HeaderText = "Modifier";
            Action.MinimumWidth = 8;
            Action.Name = "Action";
            Action.Width = 150;
            // 
            // Supprimer
            // 
            Supprimer.HeaderText = "Supprimer";
            Supprimer.MinimumWidth = 8;
            Supprimer.Name = "Supprimer";
            Supprimer.Width = 150;
            // 
            // mainScreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 581);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Name = "mainScreen";
            Text = "mainScreen";
            Load += mainScreen_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nom;
        private DataGridViewTextBoxColumn Prix;
        private DataGridViewTextBoxColumn Quantité;
        private DataGridViewTextBoxColumn Statut;
        private DataGridViewButtonColumn Action;
        private DataGridViewButtonColumn Supprimer;
    }
}