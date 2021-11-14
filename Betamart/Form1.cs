using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Betamart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        
                
        

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Anda Yakin Ingin Di Hapus?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    daftarBindingSource.RemoveCurrent();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                        pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtNama.Focus();
                this.appData.Daftar.AddDaftarRow(this.appData.Daftar.NewDaftarRow());
                daftarBindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                daftarBindingSource.ResetBindings(false);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtNama.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                daftarBindingSource.EndEdit();
                daftarTableAdapter.Update(this.appData.Daftar);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                daftarBindingSource.ResetBindings(false);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'betamartDataSet4.Daftar' table. You can move, or remove it, as needed.
            this.daftarTableAdapter3.Fill(this.betamartDataSet4.Daftar);
            // TODO: This line of code loads data into the 'betamartDataSet1.Daftar' table. You can move, or remove it, as needed.
            this.daftarTableAdapter2.Fill(this.betamartDataSet1.Daftar);
            // TODO: This line of code loads data into the 'betamartDataSet.Daftar' table. You can move, or remove it, as needed.
            this.daftarTableAdapter1.Fill(this.betamartDataSet.Daftar);
            // TODO: This line of code loads data into the 'appData.Daftar' table. You can move, or remove it, as needed.
            this.daftarTableAdapter.Fill(this.appData.Daftar);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStok_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
