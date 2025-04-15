namespace InventurProgramm {
    partial class FormAddItem {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            labelItem = new Label();
            textBoxItem = new TextBox();
            labelAmount = new Label();
            labelLocation = new Label();
            labelComment = new Label();
            textBoxLocation = new TextBox();
            textBoxAmount = new TextBox();
            textBoxComment = new TextBox();
            buttonConfirm = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelItem
            // 
            labelItem.AutoSize = true;
            labelItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelItem.Location = new Point(61, 35);
            labelItem.Name = "labelItem";
            labelItem.Size = new Size(37, 15);
            labelItem.TabIndex = 0;
            labelItem.Text = "Item:";
            // 
            // textBoxItem
            // 
            textBoxItem.Location = new Point(104, 32);
            textBoxItem.Name = "textBoxItem";
            textBoxItem.Size = new Size(139, 23);
            textBoxItem.TabIndex = 1;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAmount.Location = new Point(49, 85);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(49, 15);
            labelAmount.TabIndex = 2;
            labelAmount.Text = "Menge:";
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelLocation.Location = new Point(69, 130);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(29, 15);
            labelLocation.TabIndex = 3;
            labelLocation.Text = "Ort:";
            // 
            // labelComment
            // 
            labelComment.AutoSize = true;
            labelComment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelComment.Location = new Point(21, 174);
            labelComment.Name = "labelComment";
            labelComment.Size = new Size(77, 15);
            labelComment.TabIndex = 4;
            labelComment.Text = "Kommentar:";
            // 
            // textBoxLocation
            // 
            textBoxLocation.Location = new Point(104, 127);
            textBoxLocation.Name = "textBoxLocation";
            textBoxLocation.Size = new Size(139, 23);
            textBoxLocation.TabIndex = 6;
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(104, 82);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(139, 23);
            textBoxAmount.TabIndex = 5;
            // 
            // textBoxComment
            // 
            textBoxComment.Location = new Point(104, 171);
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(139, 23);
            textBoxComment.TabIndex = 7;
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(49, 240);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(75, 28);
            buttonConfirm.TabIndex = 8;
            buttonConfirm.Text = "Bestätigen";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(168, 240);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 28);
            buttonCancel.TabIndex = 9;
            buttonCancel.Text = "Abbrechen";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormAddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 294);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Controls.Add(textBoxComment);
            Controls.Add(textBoxAmount);
            Controls.Add(textBoxLocation);
            Controls.Add(labelComment);
            Controls.Add(labelLocation);
            Controls.Add(labelAmount);
            Controls.Add(textBoxItem);
            Controls.Add(labelItem);
            Name = "FormAddItem";
            Text = "Item hinzufügen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelItem;
        private TextBox textBoxItem;
        private Label labelAmount;
        private Label labelLocation;
        private Label labelComment;
        private TextBox textBoxLocation;
        private TextBox textBoxAmount;
        private TextBox textBoxComment;
        private Button buttonConfirm;
        private Button buttonCancel;
    }
}