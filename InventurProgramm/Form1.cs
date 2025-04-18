using System.Windows.Forms.PropertyGridInternal;
using System.Windows.Forms.VisualStyles;

namespace InventurProgramm {
    public partial class Form1 : BaseForm {
        public Form1() {
            InitializeComponent();
            this.Load += Form1_Load;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
        }



        private void Form1_Load(object? sender, EventArgs e) {



            // get rid of empty index column on the left side of the dataGrid
            dataGridView1.RowHeadersVisible = false;
            try {
                // check if a path to a CSV file is set in user config file, if the path is valid and if the set file exists
                if (!string.IsNullOrEmpty(Properties.Settings.Default.CsvFilePath) || File.Exists(Properties.Settings.Default.CsvFilePath)) {
                    // call custom method to read data from CSV file
                    readCSVFile(Properties.Settings.Default.CsvFilePath);
                } else {
                    throw new FilePathException("Kein gültiger Pfad angegeben oder Datei existiert nicht");
                }
            } catch (FilePathException ex) {

                MessageBox.Show(ex.Message);
                return;
            }
            labelVersion.BackColor = Color.Transparent;
            labelVersion.Parent = this;
        }



        private void readCSVFile(string filepath) {
            StreamReader reader = new StreamReader(filepath);

            using (reader) {
                // read CSV file with StreamReader, split the columns and put the data in the respective columns in the dataGrid
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] values = line.Split(';');
                    dataGridView1.Rows.Add(values[0], values[1], values[2], values[3]);
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }


        // method to open the File Explorer to allow the user to set a new path to a CSV file
        private void toolStripMenuItem2_Click(object sender, EventArgs e) {
            // clearing the dataGrid first to prevent old and new data from mixing in dataGrid
            deleteRows();

            OpenFileDialog openFileDialog = new OpenFileDialog() {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "CSV-Datei zum Auslesen auswählen"
            };
            openFileDialog.ShowDialog();

            // save file path in user config file to allow data to be fetched on startup. this path will be checked and used on startup
            Properties.Settings.Default.CsvFilePath = openFileDialog.FileName;
            Properties.Settings.Default.Save();

            readCSVFile(openFileDialog.FileName);
        }

        private void deleteRows() {
            while (dataGridView1.Rows.Count > 0) {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            }
        }

        private void mengeÄndernToolStripMenuItem_Click(object sender, EventArgs e) {
            FormChangeAmount formChangeAmount = new FormChangeAmount();
            formChangeAmount.StartPosition = FormStartPosition.CenterParent;

            string item;
            string amount;

            if (formChangeAmount.ShowDialog() == DialogResult.OK) {
                item = formChangeAmount.item;
                amount = formChangeAmount.amount.ToString();

                try {
                    changeItem(item, amount);
                } catch (ItemNotFoundException ex) {
                    MessageBox.Show("Item existiert nicht, prüfen Sie auf mögliche Tippfehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                formChangeAmount.Dispose();
                return;
            }

            reloadCSV();

        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e) {
            // check if rightclick and valid row/column
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                // select current cell
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // mouse position on screen in coordinates
                Point mousePosition = Cursor.Position;

                // show contextMenuStrip
                contextMenuStrip1.Show(mousePosition);
            }
        }

        private void itemHinzufügenToolStripMenuItem_Click(object sender, EventArgs e) {
            // create object for FormAddItem
            FormAddItem formAddItem = new FormAddItem();
            formAddItem.StartPosition = FormStartPosition.CenterParent; // centers the new window upon opening relative to the parent, Form1
            //formAddItem.ShowDialog();

            string item;
            string amount;
            string location;
            string comment;

            if (formAddItem.ShowDialog() == DialogResult.OK) {
                item = formAddItem.item;
                amount = formAddItem.amount.ToString();
                location = formAddItem.location;
                comment = formAddItem.comment;
            } else {
                formAddItem.Dispose();
                return;
            }

            if (checkForItem(item)) {
                MessageBox.Show("Der Artikel existiert bereits", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else {
                appendToCSV(Properties.Settings.Default.CsvFilePath, item, amount, location, comment);
                reloadCSV();
                formAddItem.Dispose();
            }
        }

        private void appendToCSV(string file, string item, string amount, string location, string comment) {
            string[] values = new string[4];
            values[0] = item;
            values[1] = amount;
            values[2] = location;
            values[3] = comment;

            string newLine = string.Join(";", values);
            File.AppendAllText(file, newLine + Environment.NewLine);
        }

        private void appendToCSV(string file, string[] values) {
            string newLine = string.Join(";", values);
            File.AppendAllText(file, newLine + Environment.NewLine);
        }

        private void reloadCSV() {
            deleteRows();
            readCSVFile(Properties.Settings.Default.CsvFilePath);
        }

        private void deleteItem(string item) {

            if (!checkForItem(item)) {
                throw new ItemNotFoundException();
            }

            string filePath = Properties.Settings.Default.CsvFilePath;
            string tempFile = Path.GetTempFileName();
            using (StreamWriter writer = new StreamWriter(tempFile))
            using (StreamReader reader = new StreamReader(filePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] values = new string[4];
                    values = line.Split(";");
                    if (values[0].Equals(item, StringComparison.InvariantCultureIgnoreCase)) {
                        continue;
                    } else {
                        writer.WriteLine(line);
                    }
                }
            }
            File.Copy(tempFile, filePath, true);
            File.Delete(tempFile);
        }

        private void itemEntfernenToolStripMenuItem_Click(object sender, EventArgs e) {
            FormDeleteItem formDeleteItem = new FormDeleteItem();
            formDeleteItem.StartPosition = FormStartPosition.CenterParent;

            if (formDeleteItem.ShowDialog() == DialogResult.OK) {
                try {
                    deleteItem(formDeleteItem.item);

                } catch (ItemNotFoundException ex) {
                    MessageBox.Show("Item existiert nicht, prüfen Sie auf mögliche Tippfehler", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                formDeleteItem.Dispose();
                return;
            }

            reloadCSV();
        }

        internal static Boolean checkForItem(string item) {

            using (StreamReader reader = new StreamReader(Properties.Settings.Default.CsvFilePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] values = line.Split(";");
                    if (values[0].Equals(item, StringComparison.InvariantCultureIgnoreCase)) {
                        return true;
                    }
                }
            }
            return false;
        }

        private void changeAmountContextToolStripMenuItem_Click(object sender, EventArgs e) {
            
        }

        private void changeItem(string item, string amount) {

            string filePath = Properties.Settings.Default.CsvFilePath;
            string tempFile = Path.GetTempFileName();


            using (StreamReader reader = new StreamReader(filePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    string[] values = line.Split(";");
                    if (values[0].Equals(item, StringComparison.InvariantCultureIgnoreCase)) {
                        values[1] = amount;
                        appendToCSV(tempFile, values);
                    } else {
                        appendToCSV(tempFile, values);
                    }
                }
            }

            File.Copy(tempFile, filePath, true);
            File.Delete(tempFile);
        }
    }
}
