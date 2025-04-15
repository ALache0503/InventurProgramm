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
    public partial class FormDeleteItem : BaseForm {

        public string item {
            get; private set;
        }

        public FormDeleteItem() {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(textBoxItem.Text)) {
                MessageBox.Show("Feld \"Item\" darf nicht leer sein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            this.item = textBoxItem.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
