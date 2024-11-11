using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Northwind.FORMULARIS
{
    public partial class FrmRegions : Form
    {
        // propietats
        SqlConnection dbConnection { get; set; }
        SqlDataAdapter dbAdapter { get; set; }
        DataSet dSet { get; set; } = new DataSet();

        //Variables Globals
        String connectionString = "Data Source=DESKTOP-GSO4EB7\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        FrmAMBRegio fAMBRegions;
        public FrmRegions()
        {
            InitializeComponent();
        }

        private void FrmRegions_Load(object sender, EventArgs e)
        {
            try
            {
                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
                if (dbConnection.State == ConnectionState.Open)
                {
                    getDades();
                    iniDgrid();
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void getDades()
        {
            String xsql = "";
            xsql = "SELECT * FROM Region";

            dbAdapter = new SqlDataAdapter(xsql, dbConnection);
            dSet.Clear();
            dbAdapter.Fill(dSet);
            dgDades.DataSource = dSet.Tables[0];
        }
        private void iniDgrid()
        {
            dgDades.Columns["RegionID"].HeaderText = "ID";
            dgDades.Columns["RegionDescription"].HeaderText = "Descripcio";
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fAMBRegions = new FrmAMBRegio('B', dbConnection);
            fAMBRegions.id = dgDades.SelectedRows[0].Cells[0].Value.ToString();
            fAMBRegions.descripcio = dgDades.SelectedRows[0].Cells[1].Value.ToString();
            fAMBRegions.ShowDialog();
            getDades();
            fAMBRegions = null;
        }
        private void dgDades_MouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fAMBRegions = new FrmAMBRegio('M', dbConnection);
            fAMBRegions.id = dgDades.SelectedRows[0].Cells[0].Value.ToString();
            fAMBRegions.descripcio = dgDades.SelectedRows[0].Cells[1].Value.ToString();
            fAMBRegions.ShowDialog();
            getDades();
            fAMBRegions = null;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fAMBRegions = new FrmAMBRegio('A', dbConnection);
            fAMBRegions.ShowDialog();
            getDades();
            fAMBRegions = null;
        }
    }
}