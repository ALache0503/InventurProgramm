using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventurProgramm {
    public partial class FormAddItem : BaseForm {

        // string variables with public get and private set to store input and use in Form1
        public string item {
            get; private set;
        }

        public int amount {
            get; private set;
        }

        public string location {
            get; private set;
        }

        public string comment {
            get; private set;
        }


        public FormAddItem() {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e) {
            this.item = textBoxItem.Text;

            if (int.TryParse(textBoxAmount.Text, out int result)) {
                this.amount = result;
            } else {
                MessageBox.Show("Die eingegebene Menge muss eine ganze Zahl sein", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.location = textBoxLocation.Text;

            if (textBoxComment.Text.Length <= 0) {
                this.comment = "-";
            } else {
                this.comment = textBoxComment.Text;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
