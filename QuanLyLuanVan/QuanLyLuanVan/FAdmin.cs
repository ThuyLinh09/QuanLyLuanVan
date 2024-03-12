using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyLuanVan
{
    public partial class FAdmin : Form
    {

        public FAdmin()
        {
            InitializeComponent();
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void FAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLuanVanDataSet.nckh_teachers' table. You can move, or remove it, as needed.
            //this.nckh_teachersTableAdapter.Fill(this.quanLyLuanVanDataSet.nckh_teachers);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.nckh_teachersTableAdapter.FillBy(this.quanLyLuanVanDataSet.nckh_teachers);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
