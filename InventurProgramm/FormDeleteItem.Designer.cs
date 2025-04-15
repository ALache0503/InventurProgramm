
namespace InventurProgramm {
    partial class FormDeleteItem {
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
            textBoxItem = new TextBox();
            labelItem = new Label();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(39, 68);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(75, 28);
            buttonConfirm.TabIndex = 0;
            buttonConfirm.Text = "Bestätigen";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // textBoxItem
            // 
            textBoxItem.Location = new Point(82, 19);
            textBoxItem.Name = "textBoxItem";
            textBoxItem.Size = new Size(100, 23);
            textBoxItem.TabIndex = 1;
            // 
            // labelItem
            // 
            labelItem.AutoSize = true;
            labelItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelItem.Location = new Point(39, 22);
            labelItem.Name = "labelItem";
            labelItem.Size = new Size(37, 15);
            labelItem.TabIndex = 2;
            labelItem.Text = "Item:";
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(146, 68);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 28);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Abbrechen";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormDeleteItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 108);
            Controls.Add(buttonCancel);
            Controls.Add(labelItem);
            Controls.Add(textBoxItem);
            Controls.Add(buttonConfirm);
            MaximizeBox = false;
            Name = "FormDeleteItem";
            Text = "Item entfernen";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button buttonConfirm;
        private TextBox textBoxItem;
        private Label labelItem;
        private Button buttonCancel;
    }
}