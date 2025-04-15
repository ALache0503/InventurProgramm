using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventurProgramm
{
    public partial class FormChangeAmount : Form {

        public string item { get; private set; }
        public int amount { get; private set; }

        public FormChangeAmount() {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e) {
            if (Form1.checkForItem(textBoxItem.Text)) {
                this.item = textBoxItem.Text;
            } else {
                MessageBox.Show("Item existiert nicht, prüfen Sie auf mögliche Tippfehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(textBoxAmount.Text, out int result)) {
                this.amount = result;
            } else {
                MessageBox.Show("Die eingegebene Menge muss eine ganze Zahl sein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
