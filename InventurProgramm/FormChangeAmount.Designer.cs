namespace InventurProgramm {
    partial class FormChangeAmount {
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
            buttonConfirm = new Button();
            buttonCancel = new Button();
            labelItem = new Label();
            textBoxItem = new TextBox();
            labelAmount = new Label();
            textBoxAmount = new TextBox();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(36, 225);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(75, 28);
            buttonConfirm.TabIndex = 0;
            buttonConfirm.Text = "Bestätigen";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(170, 225);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 28);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Abbrechen";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // labelItem
            // 
            labelItem.AutoSize = true;
            labelItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelItem.Location = new Point(88, 36);
            labelItem.Name = "labelItem";
            labelItem.Size = new Size(37, 15);
            labelItem.TabIndex = 2;
            labelItem.Text = "Item:";
            // 
            // textBoxItem
            // 
            textBoxItem.Location = new Point(131, 33);
            textBoxItem.Name = "textBoxItem";
            textBoxItem.Size = new Size(100, 23);
            textBoxItem.TabIndex = 3;
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAmount.Location = new Point(45, 92);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(80, 15);
            labelAmount.TabIndex = 4;
            labelAmount.Text = "neue Menge:";
            // 
            // textBoxAmount
            // 
            textBoxAmount.Location = new Point(131, 89);
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.Size = new Size(100, 23);
            textBoxAmount.TabIndex = 5;
            // 
            // FormChangeAmount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 294);
            Controls.Add(textBoxAmount);
            Controls.Add(labelAmount);
            Controls.Add(textBoxItem);
            Controls.Add(labelItem);
            Controls.Add(buttonCancel);
            Controls.Add(buttonConfirm);
            Name = "FormChangeAmount";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Menge ändern";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConfirm;
        private Button buttonCancel;
        private Label labelItem;
        private TextBox textBoxItem;
        private Label labelAmount;
        private TextBox textBoxAmount;
    }
}