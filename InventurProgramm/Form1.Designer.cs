namespace InventurProgramm
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
        private void InitializeComponent() {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            bearbeitenToolStripMenuItem = new ToolStripMenuItem();
            itemEntfernenToolStripMenuItem = new ToolStripMenuItem();
            itemHinzufügenToolStripMenuItem = new ToolStripMenuItem();
            mengeÄndernToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            changeAmountContextToolStripMenuItem = new ToolStripMenuItem();
            labelVersion = new Label();
            labelFilter = new Label();
            textBoxFilter = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, bearbeitenToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(46, 20);
            toolStripMenuItem1.Text = "Datei";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(161, 22);
            toolStripMenuItem2.Text = "Dateipfad setzen";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // bearbeitenToolStripMenuItem
            // 
            bearbeitenToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { itemEntfernenToolStripMenuItem, itemHinzufügenToolStripMenuItem, mengeÄndernToolStripMenuItem });
            bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            bearbeitenToolStripMenuItem.Size = new Size(75, 20);
            bearbeitenToolStripMenuItem.Text = "Bearbeiten";
            // 
            // itemEntfernenToolStripMenuItem
            // 
            itemEntfernenToolStripMenuItem.Name = "itemEntfernenToolStripMenuItem";
            itemEntfernenToolStripMenuItem.Size = new Size(161, 22);
            itemEntfernenToolStripMenuItem.Text = "Item entfernen";
            itemEntfernenToolStripMenuItem.Click += itemEntfernenToolStripMenuItem_Click;
            // 
            // itemHinzufügenToolStripMenuItem
            // 
            itemHinzufügenToolStripMenuItem.Name = "itemHinzufügenToolStripMenuItem";
            itemHinzufügenToolStripMenuItem.Size = new Size(161, 22);
            itemHinzufügenToolStripMenuItem.Text = "Item hinzufügen";
            itemHinzufügenToolStripMenuItem.Click += itemHinzufügenToolStripMenuItem_Click;
            // 
            // mengeÄndernToolStripMenuItem
            // 
            mengeÄndernToolStripMenuItem.Name = "mengeÄndernToolStripMenuItem";
            mengeÄndernToolStripMenuItem.Size = new Size(161, 22);
            mengeÄndernToolStripMenuItem.Text = "Menge ändern";
            mengeÄndernToolStripMenuItem.Click += mengeÄndernToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(0, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.ReadOnly = true;
            dataGridView1.Size = new Size(800, 379);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Item";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Menge";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Ort";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kommentar";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { changeAmountContextToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(152, 26);
            // 
            // changeAmountContextToolStripMenuItem
            // 
            changeAmountContextToolStripMenuItem.Name = "changeAmountContextToolStripMenuItem";
            changeAmountContextToolStripMenuItem.Size = new Size(151, 22);
            changeAmountContextToolStripMenuItem.Text = "Menge ändern";
            changeAmountContextToolStripMenuItem.Click += changeAmountContextToolStripMenuItem_Click;
            // 
            // labelVersion
            // 
            labelVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            labelVersion.BackColor = SystemColors.Control;
            labelVersion.Location = new Point(737, 436);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(63, 15);
            labelVersion.TabIndex = 2;
            labelVersion.Text = "Version 1.0";
            // 
            // labelFilter
            // 
            labelFilter.AutoSize = true;
            labelFilter.Location = new Point(652, 29);
            labelFilter.Name = "labelFilter";
            labelFilter.Size = new Size(36, 15);
            labelFilter.TabIndex = 3;
            labelFilter.Text = "Filter:";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(694, 26);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(100, 23);
            textBoxFilter.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxFilter);
            Controls.Add(labelFilter);
            Controls.Add(labelVersion);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem bearbeitenToolStripMenuItem;
        private ToolStripMenuItem itemEntfernenToolStripMenuItem;
        private ToolStripMenuItem itemHinzufügenToolStripMenuItem;
        private ToolStripMenuItem mengeÄndernToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem changeAmountContextToolStripMenuItem;
        private Label labelVersion;
        private Label labelFilter;
        private TextBox textBoxFilter;
    }
}
