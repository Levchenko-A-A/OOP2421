using CsvHelper.Configuration;
using CsvHelper;
using Lesson25._1;
using System.Globalization;

namespace Lesson25._2
{
    public partial class Form1 : Form
    {
        private List<Inventory> records;
        public Form1()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader("inventoryControl.csv");
            CsvReader csvReader = new CsvReader(reader,
                new CsvConfiguration(CultureInfo.InvariantCulture));
            records = csvReader.GetRecords<Inventory>().ToList();
            reader.Close();
            UpDateForm(records);
            comboBoxFilter.SelectedIndex = 0;
        }
        private void UpDateForm(List<Inventory> amp)
        {
            dataGridViewInventors.DataSource = null;
            dataGridViewInventors.DataSource = amp;
            for (int i = 0; i < dataGridViewInventors.Columns.Count; i++)
            {
                dataGridViewInventors.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewInventors.Columns[i].ReadOnly = true;
            }
            toolStripStatusLabelCount.Text = "Êîëè÷åñòâî çàïèñåé " + amp.Count.ToString();
        }

        private void dataGridViewInventors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewInventors.SelectedCells.Count > 0)
            {
                int index = dataGridViewInventors.SelectedRows[0].Index;
                textBoxQuant.Text = records[index].Quantity.ToString();
                textBoxName.Text = records[index].Name;
                textBoxPrice.Text = records[index].Price.ToString();
                textBoxDesc.Text = records[index].Description;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Name = textBoxName.Text;
            inventory.Quantity = int.Parse(textBoxQuant.Text);
            inventory.Price = decimal.Parse(textBoxPrice.Text);
            inventory.Description = textBoxDesc.Text;
            records.Add(inventory);
            UpDateForm(records);
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("C:\\Install\\inventoryControl.csv");
            CsvWriter csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));
            csvWriter.WriteRecords(records);
            writer.Close();
            MessageBox.Show("Ôàéë ñîõðàíåí");
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventors.SelectedCells.Count > 0)
            {
                int index = dataGridViewInventors.SelectedRows[0].Index;
                records[index].Quantity = int.Parse(textBoxQuant.Text);
                records[index].Name = textBoxName.Text;
                records[index].Price = decimal.Parse(textBoxPrice.Text);
                records[index].Description = textBoxDesc.Text;
                UpDateForm(records);
            }
        }

        private void dataGridViewInventors_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dataGridViewInventors.SelectedCells.Count > 0)
                {
                    int index = dataGridViewInventors.SelectedRows[0].Index;
                    records.RemoveAt(index);
                    UpDateForm(records);
                }
            }

        }

        private void textBoxSeach_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSeach.Text.Length != 0)
            {
                switch (comboBoxFilter.SelectedIndex)
                {

                    case 0:
                        {
                            List<Inventory> list = records.Where(p => p.Name.ToLower().StartsWith(textBoxSeach.Text.ToLower())).ToList();
                            UpDateForm(list);
                        }
                        break;
                    case 1:
                        {
                            List<Inventory> list = records.Where(p => p.Quantity==int.Parse(textBoxSeach.Text)).ToList();
                            UpDateForm(list);
                        }
                        break;
                    case 2:
                        {
                            List<Inventory> list = records.Where(p => p.Price == int.Parse(textBoxSeach.Text)).ToList();
                            UpDateForm(list);
                        }
                        break;
                }
            }
            else UpDateForm(records);
        }
    }
}
