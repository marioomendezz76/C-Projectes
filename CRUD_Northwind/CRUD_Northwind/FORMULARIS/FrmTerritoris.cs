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
    public partial class FrmTerritoris : Form
    {
        // propietats   
        SqlConnection dbConnection { get; set; }
        SqlDataAdapter dbAdapter { get; set; }
        DataSet dSet { get; set; } = new DataSet();

        //Variables Globals
        String connectionString = "Data Source=DESKTOP-GSO4EB7\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        // formularis
        FrmAMBTerritoris fAMBTerritoris;

        public FrmTerritoris()
        {
            InitializeComponent();
        }

        private void FrmTerritoris_Load(object sender, EventArgs e)
        {
            try
            {
                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
                if (dbConnection.State == ConnectionState.Open)
                {
                    getDades();
                    iniDgrid();
                    omplirComboRegions();
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
            if ((cbRegions.SelectedValue != null) && (cbRegions.Enabled))
            {
                String idRegio = ((DataRowView)cbRegions.SelectedItem)["RegionID"].ToString();
                xsql = "SELECT * FROM Territories T JOIN Region R ON (T.RegionID=R.RegionID) WHERE (T.RegionID='" + idRegio + "') ORDER BY TerritoryDescription";
            }
            else
            {
                xsql = "SELECT * FROM Territories T JOIN Region R ON (T.RegionID=R.RegionID) ORDER BY TerritoryDescription";
            }

            dbAdapter = new SqlDataAdapter(xsql, dbConnection);
            dSet.Clear();
            dbAdapter.Fill(dSet);
            dgDades.DataSource = dSet.Tables[0];
        }

        private void iniDgrid()
        {
            dgDades.Columns["TerritoryID"].HeaderText = "ID";
            dgDades.Columns["TerritoryDescription"].HeaderText = "Descripcio";
            dgDades.Columns["RegionDescription"].HeaderText = "Regio";
            dgDades.Columns["RegionID"].Visible = false;
            dgDades.Columns["RegionID1"].Visible = false;
        }

        private void omplirComboRegions()
        {
            DataSet xdset = new DataSet();
            String xsql = "SELECT * FROM Region ORDER BY RegionDescription";

            dbAdapter = new SqlDataAdapter(xsql, dbConnection);
            xdset.Clear();
            dbAdapter.Fill(xdset);
            if (xdset.Tables[0].Rows.Count > 0)
            {
                cbRegions.DataSource = xdset.Tables[0];
                cbRegions.DisplayMember = "RegionDescription";
                cbRegions.ValueMember = "RegionID";
            }
            else
            {
                cbRegions.DataSource = null;
                cbRegions.DisplayMember = "";
                cbRegions.ValueMember = "";
            }
        }

        private void cbRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDades();
        }

        private void ckbTotes_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTotes.Checked)
            {
                cbRegions.Enabled = false;
                getDades();
            }
            else
            {
                cbRegions.Enabled = true;
                getDades();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fAMBTerritoris = new FrmAMBTerritoris('A', dbConnection);
            fAMBTerritoris.ShowDialog();
            getDades();
            fAMBTerritoris = null;
        }

        private void dgDades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fAMBTerritoris = new FrmAMBTerritoris('M', dbConnection);
            fAMBTerritoris.id = dgDades.SelectedRows[0].Cells[0].Value.ToString();
            fAMBTerritoris.descripcio = dgDades.SelectedRows[0].Cells[1].Value.ToString();
            fAMBTerritoris.idRegio = (int)dgDades.SelectedRows[0].Cells[2].Value;
            fAMBTerritoris.ShowDialog();
            getDades();
            fAMBTerritoris = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fAMBTerritoris = new FrmAMBTerritoris('B', dbConnection);
            fAMBTerritoris.id = dgDades.SelectedRows[0].Cells[0].Value.ToString();
            fAMBTerritoris.descripcio = dgDades.SelectedRows[0].Cells[1].Value.ToString();
            fAMBTerritoris.idRegio = (int)dgDades.SelectedRows[0].Cells[2].Value;
            fAMBTerritoris.ShowDialog();
            getDades();
            fAMBTerritoris = null;
        }
    }
}