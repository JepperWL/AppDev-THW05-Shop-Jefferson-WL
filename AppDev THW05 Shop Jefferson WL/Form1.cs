using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AppDev_THW05_Shop_Jefferson_WL
{
    public partial class JefferShop : Form
    {
        public JefferShop()
        {
            InitializeComponent();
        }
        DataTable dtProduksimpan = new DataTable();
        DataTable dtProduktampil = new DataTable();
        DataTable dtCategory = new DataTable();
        string idproduk = "";
        public string categoryID = "";
        public string product = "";
        Dictionary<string, List<int>> existingIds = new Dictionary<string, List<int>>();
        private void JefferShop_Load(object sender, EventArgs e)
        {

            dtProduksimpan.Columns.Add("ID Product");
            dtProduksimpan.Columns.Add("Nama Product");
            dtProduksimpan.Columns.Add("Harga");
            dtProduksimpan.Columns.Add("Stock");
            dtProduksimpan.Columns.Add("ID Category");

            dtCategory.Columns.Add("ID Category", typeof(string));
            dtCategory.Columns.Add("Nama Category", typeof(string));

            dtProduksimpan.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            dtProduksimpan.Rows.Add("T001", "T - Shirt Black Pink", "70000", "20", "C2");
            dtProduksimpan.Rows.Add("T002", "T - Shirt Obsessive", "75000", "16", "C2");
            dtProduksimpan.Rows.Add("R001", "Rok Mini", "82000", "26", "C3");
            dtProduksimpan.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            dtProduksimpan.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            dtProduksimpan.Rows.Add("C002", "Cawat Blink - Blink", "1000000", "1", "C5");
            dtProduksimpan.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");

            dtCategory.Rows.Add("C1", "Jas");
            dtCategory.Rows.Add("C2", "T-Shirt");
            dtCategory.Rows.Add("C3", "Rok");
            dtCategory.Rows.Add("C4", "Celana");
            dtCategory.Rows.Add("C5", "Cawat");

            dtProduktampil = dtProduksimpan.Copy();
            dataGridViewCategory.DataSource = dtCategory;

            comboBoxFilter.Text = "";
            comboBoxFilter.DataSource = dtCategory.Copy();
            comboBoxFilter.DisplayMember = "Nama Category";
            comboBoxFilter.ValueMember = "ID Category";
            dataGridViewCategory.CurrentCell = null;
            dataGridViewProduct.ClearSelection();
            dataGridViewProduct.CurrentCell = null;
            comboBoxFilter.Enabled = false;


            comboBoxCategory.DataSource = dtCategory;
            comboBoxCategory.Text = "";
            comboBoxCategory.DisplayMember = "Nama Category";
            comboBoxCategory.ValueMember = "ID Category";
            comboBoxCategory.Enabled = true;
            this.BackColor = Color.Beige;
            dataGridViewProduct.DataSource = dtProduktampil;
           
            dataGridViewProduct.ClearSelection();
            comboBoxCategory.Text = "";
            comboBoxFilter.Text = "";

            foreach (DataRow row in dtProduksimpan.Rows)
            {
                string id = row.Field<string>("ID Product");
                string hurufDepan = id.Substring(0, 1).ToUpper();
                int numericId = int.Parse(id.Substring(1));

                if (!existingIds.ContainsKey(hurufDepan))
                {
                    existingIds[hurufDepan] = new List<int>();
                }

                existingIds[hurufDepan].Add(numericId);
            }
        }



     

        //private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        //{
          
        //}

        
        bool select = false;
        private void btnFilter_Click(object sender, EventArgs e)
        {
            comboBoxFilter.Enabled = true;
            select = true;
        }

        private void comboBoxFilter_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nama;
            nama = comboBoxFilter.SelectedValue.ToString();
            foreach (DataRow row in dtCategory.Rows)
            {
                if (row[0].ToString() == nama)
                {
                    nama = row[1].ToString();
                    break;
                }
            }
            CaraFilter(comboBoxFilter.SelectedValue.ToString());
            if (select == true)
            {
                comboBoxFilter.Text = nama;
            }
        }

      

        private void btnAddproduct_Click(object sender, EventArgs e)
        {
            if (tbxNama.Text == "" || tbxHarga.Text == "" || tbxStock.Text == "" || comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("Inputtan Tidak Ada Boleh Yang Kosong", "Please Read This", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hurufDepan = tbxNama.Text.Substring(0, 1).ToUpper();
            int newId = GetNextAvailableId(hurufDepan);

            string newIdTampilan = hurufDepan + newId.ToString("D3");

            DataRow row = dtProduksimpan.NewRow();
            row[0] = newIdTampilan;
            row[1] = tbxNama.Text;
            row[2] = tbxHarga.Text;
            row[3] = tbxStock.Text;
            row[4] = comboBoxCategory.SelectedValue;
            dtProduksimpan.Rows.Add(row);
       
            existingIds[hurufDepan].Add(newId);

            CaraFilter("");


        }
        private int GetNextAvailableId(string hurufDepan)
        {
            if (!existingIds.ContainsKey(hurufDepan))
            {
                existingIds[hurufDepan] = new List<int>();
            }

            int nextId = 1;

            while (existingIds[hurufDepan].Contains(nextId))
            {
                nextId++;
            }

            return nextId;
        }


        //private void tbxNama_TextChanged(object sender, EventArgs e)
        //{
        //    if (tbxNama.Text != "")
        //    {
        //        int angka = 1;
        //        for (int i = 0; i < dtProduksimpan.Rows.Count; i++)
        //        {
        //            if (dtProduksimpan.Rows[i][0].ToString().Substring(0, 1).ToUpper() == tbxNama.Text.ToString().Substring(0, 1).ToUpper())
        //            {
        //                angka++;
        //            }
        //        }

        //        idproduk = tbxNama.Text.ToString().Substring(0, 1).ToUpper() + "00" + angka;
        //    }

        //}

        private void dataGridViewProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewProduct.Rows[e.RowIndex];
            idproduk = row.Cells[0].Value.ToString();
            tbxNama.Text = row.Cells[1].Value.ToString();
            tbxHarga.Text = row.Cells[2].Value.ToString();
            tbxStock.Text = row.Cells[3].Value.ToString();
            comboBoxCategory.SelectedValue = row.Cells[4].Value.ToString();
        }

        private void dataGridViewCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            categoryID = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbxNamaCategory.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string Categoryname = tbxNamaCategory.Text;
            var adaID = dtCategory.AsEnumerable().Select(row => row.Field<string>("ID Category"));
            bool check = false;
            foreach (DataRow row in dtCategory.Rows)
            {
                if (tbxNamaCategory.Text != row[1].ToString())
                {
                    continue;
                }
                check = true;
            }
            if (check == true)
            {
                MessageBox.Show("Category sudah ada", "Please Read This", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxNamaCategory.Text = "";
                return;
            }
            string hurufDepan = "C";
            int newId = 1;

            if (Categoryname == "")
            {
                MessageBox.Show("Masukkan Nama Category terlebih dahulu", "Please Read This", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            while (adaID.Contains(hurufDepan + newId))
            {
                newId++;
            }

            string newIdCategory = hurufDepan + newId;

            DataRow roww = dtCategory.NewRow();
            roww[0] = newIdCategory;
            roww[1] = Categoryname;

            dtCategory.Rows.Add(roww);

            CaraFilter("");

        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            string Categoryname = tbxNamaCategory.Text;
            if (Categoryname == "")
            {
                MessageBox.Show("Pilih Objek Kategori Yang Ingin dihapus terlebih dahulu", "Please Read This", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int i;
            foreach (DataRow row in dtCategory.Rows)
            {
                if (row[0].ToString() != categoryID)
                {
                    continue;
                }
                dtCategory.Rows.Remove(row);
                for (i = dtProduksimpan.Rows.Count - 1; i >= 0; i--)
                {
                    if (dtProduksimpan.Rows[i]["ID Category"] == categoryID)
                    {
                        dtProduksimpan.Rows.Remove(dtProduksimpan.Rows[i]);
                    }
                }
                CaraFilter("");
                return;
            }
            for (i = dtProduksimpan.Rows.Count - 1; i >= 0; i--)
            {
                if (dtProduksimpan.Rows[i]["ID Category"] == categoryID)
                {
                    dtProduksimpan.Rows.Remove(dtProduksimpan.Rows[i]);
                }
            }
            CaraFilter("");
        }


        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (tbxNama.Text == "" || tbxHarga.Text == "" || tbxStock.Text == "" || comboBoxCategory.SelectedValue == null)
            {
                MessageBox.Show("Pilih Objek yang ingin dihapus terlebih dahulu !", "Please Read This", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (DataRow row in dtProduksimpan.Rows)
            {
               
                if (row[0].ToString() != idproduk)
                {
                    continue;
                }
                if(row[0].ToString() == idproduk)
                {
                    MessageBox.Show(row + " " + idproduk);
                    dtProduksimpan.Rows.Remove(row);
                    CaraFilter("");
                    return;
                }
              
            }
            CaraFilter("");
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (idproduk == "")
            {
                MessageBox.Show("Pilih Objek yang ingin diedit terlebih dahulu !", "Please Read This", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string newValueNama = tbxNama.Text;
                string newValueCategory = comboBoxCategory.SelectedValue.ToString();
                float newValueHarga = Convert.ToInt64(tbxHarga.Text);
                int newValueStock = Convert.ToInt32(tbxStock.Text);
                foreach (DataRow row in dtProduksimpan.Rows)
                {
                    if (row[0].ToString() != idproduk)
                    {
                        continue;
                    }
                    else
                    {
                        row[1] = newValueNama;
                        row[2] = newValueHarga;
                        row[3] = newValueStock;
                        row[4] = newValueCategory;
                    }

                    if (row[3].ToString() != "0")
                    {
                        continue;
                    }
                    else
                    {
                        dtProduksimpan.Rows.Remove(row);
                    }

                    CaraFilter("");
                    return;
                }
            }
            CaraFilter("");
        }

        private void tbxHarga_TextChanged(object sender, EventArgs e)
        {

        }

        //private void tbxNamaCategory_TextChanged(object sender, EventArgs e)
        //{
        //    if (tbxNamaCategory.Text != "")
        //    {
        //        int angka = 1;
        //        for (int i = 0; i < dtCategory.Rows.Count; i++)
        //        {
        //            if (dtProduksimpan.Rows[i][0].ToString().Substring(0, 1).ToUpper() == tbxNamaCategory.Text.ToString().Substring(0, 1).ToUpper())
        //            {
        //                angka++;
        //            }
        //        }

        //        categoryID = tbxNamaCategory.Text.ToString().Substring(0, 1).ToUpper();
        //    }
        //}

        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        private void tbxHarga_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
                MessageBox.Show("Harus Angka", "Please Read This", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbxStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Harus Angka", "Please Read This", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CaraFilter(string nilai)
        {
            if (nilai == "")
            {
                dtProduktampil.Rows.Clear();
                for (int i = 0; i < dtProduksimpan.Rows.Count; i++)
                {
                    
                    DataRow row = dtProduktampil.NewRow();
                    row[0] = dtProduksimpan.Rows[i][0];
                    row[1] = dtProduksimpan.Rows[i][1];
                    row[2] = dtProduksimpan.Rows[i][2];
                    row[3] = dtProduksimpan.Rows[i][3];
                    row[4] = dtProduksimpan.Rows[i][4];
                    dtProduktampil.Rows.Add(row);
                }
            }
            else
            {
                dtProduktampil.Rows.Clear();
                for (int j = 0; j < dtProduksimpan.Rows.Count; j++)
                {
                   
                    if (dtProduksimpan.Rows[j][4].ToString() == nilai)
                    {
                      
                        DataRow row = dtProduktampil.NewRow();
                        row[0] = dtProduksimpan.Rows[j][0];
                        row[1] = dtProduksimpan.Rows[j][1];
                        row[2] = dtProduksimpan.Rows[j][2];
                        row[3] = dtProduksimpan.Rows[j][3];
                        row[4] = dtProduksimpan.Rows[j][4];
                        dtProduktampil.Rows.Add(row);
                    }
                }
            }

            dataGridViewProduct.CurrentCell = null;
            dataGridViewCategory.CurrentCell = null;
            tbxNama.Clear();
            tbxHarga.Clear();
            tbxStock.Clear();
            idproduk = "";
            categoryID = "";
            comboBoxCategory.DataSource = dtCategory.Copy();
            comboBoxFilter.DataSource = dtCategory.Copy();
            comboBoxCategory.Text = "";
            comboBoxFilter.Text = "";
            tbxNamaCategory.Text = "";
           

        }
        private void btnAll_Click_1(object sender, EventArgs e)
        {
            CaraFilter("");
            select = false;
            comboBoxFilter.Enabled = false;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFilter_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            string nama;
            nama = comboBoxFilter.SelectedValue.ToString();
           
            foreach (DataRow row in dtCategory.Rows)
            {
                if (row[0].ToString() == nama)
                {
                    nama = row[1].ToString();
                    break;
                }
            }
            CaraFilter(comboBoxFilter.SelectedValue.ToString());
            if (select == true)
            {
                comboBoxFilter.Text = nama;
            }
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        //private void buttonWarna_Click(object sender, EventArgs e)
        //{
        //    Random random = new Random();
        //    int red = random.Next(0, 256);
        //    int green = random.Next(0, 256);
        //    int blue = random.Next(0, 256);

        //    Color randomColor = Color.FromArgb(red, green, blue);

        //    this.BackColor = randomColor;
        //}

    }
}
