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
    public partial class FrmProductes : Form
    {
      
        // propietats   
        SqlConnection dbConnection { get; set; }
        SqlDataAdapter dbAdapter { get; set; }
        DataSet dSet { get; set; } = new DataSet();

        //Variables Globals
        String connectionString = "Data Source=DESKTOP-GSO4EB7\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

        // formularis
        FrmAMBProductes fAMBProductes;

        public FrmProductes()
        {
            InitializeComponent();
        }

        private void FrmProductes_Load(object sender, EventArgs e)
        {
            try
            {
                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
                if (dbConnection.State == ConnectionState.Open)
                {
                    getDades();
                    iniDgrid();
                    omplirComboProveidor();
                    omplirComboCategoria();
                    cbxProveidors.Checked = true;
                    cbxCategoria.Checked = true;
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void getDades()
        {
            String xsql = "SELECT * FROM Products P LEFT JOIN Suppliers S ON P.SupplierID = S.SupplierID LEFT JOIN Categories C ON P.CategoryID = C.CategoryID WHERE 1=1";

            if ((cbProveidors.SelectedValue != null) && (cbProveidors.Enabled))
            {
                String idProveidor = ((DataRowView)cbProveidors.SelectedItem)["SupplierID"].ToString();
                xsql += " AND P.SupplierID = '" + idProveidor + "'";
            }
            if ((cbCategoria.SelectedValue != null) && (cbCategoria.Enabled))
            {
                String idCategoria = ((DataRowView)cbCategoria.SelectedItem)["CategoryID"].ToString();
                xsql += " AND P.CategoryID = '" + idCategoria + "'";
            }

            xsql += " ORDER BY ProductName";

            dbAdapter = new SqlDataAdapter(xsql, dbConnection);
            dSet.Clear();
            dbAdapter.Fill(dSet);
            dgDades.DataSource = dSet.Tables[0];
        }

        private void iniDgrid()
        {
            dgDades.Columns["ProductID"].HeaderText = "ID";
            dgDades.Columns["ProductName"].HeaderText = "Nom";
            dgDades.Columns["UnitPrice"].HeaderText = "Preu";
            dgDades.Columns["Discontinued"].HeaderText = "Descontinuat";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fAMBProductes = new FrmAMBProductes('A', dbConnection);
            fAMBProductes.ShowDialog();
            getDades();
            fAMBProductes = null;
        }

        private void dgDades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fAMBProductes = new FrmAMBProductes('M', dbConnection);
            fAMBProductes.id = dgDades.SelectedRows[0].Cells[0].Value.ToString();
            fAMBProductes.nom = dgDades.SelectedRows[0].Cells[1].Value.ToString();
            fAMBProductes.preu = (float)dgDades.SelectedRows[0].Cells[1].Value;
            fAMBProductes.descontinuat = (bool)dgDades.SelectedRows[0].Cells[2].Value;
            fAMBProductes.ShowDialog();
            getDades();
            fAMBProductes = null;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fAMBProductes = new FrmAMBProductes('B', dbConnection);
            fAMBProductes.id = dgDades.SelectedRows[0].Cells[0].Value.ToString();
            fAMBProductes.nom = dgDades.SelectedRows[0].Cells[1].Value.ToString();
            fAMBProductes.preu = (float)dgDades.SelectedRows[0].Cells[2].Value;
            fAMBProductes.descontinuat = (bool)dgDades.SelectedRows[0].Cells[2].Value;
            fAMBProductes.ShowDialog();
            getDades();
            fAMBProductes = null;
        }

        private void cbxProveidors_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxProveidors.Checked)
            {
                cbProveidors.Enabled = false;
                getDades();
            }
            else
            {
                cbProveidors.Enabled = true;
                getDades();
            }
        }

        private void cbxCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCategoria.Checked)
            {
                cbCategoria.Enabled = false;
                getDades();
            }
            else
            {
                cbCategoria.Enabled = true;
                getDades();
            }
        }

        private void cbProveidors_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDades();
        }

        private void omplirComboProveidor()
        {
            DataSet xdset = new DataSet();
            String xsql = "SELECT CompanyName, SupplierID FROM Suppliers ORDER BY CompanyName";

            dbAdapter = new SqlDataAdapter(xsql, dbConnection);
            xdset.Clear();
            dbAdapter.Fill(xdset);
            if (xdset.Tables[0].Rows.Count > 0)
            {
                cbProveidors.DataSource = xdset.Tables[0];
                cbProveidors.DisplayMember = "CompanyName";
                cbProveidors.ValueMember = "SupplierID";
            }
            else
            {
                cbProveidors.DataSource = null;
                cbProveidors.DisplayMember = "";
                cbProveidors.ValueMember = "";
            }

        }
        private void omplirComboCategoria()
        {
            DataSet xdset = new DataSet();
            String xsql = "SELECT CategoryName, CategoryID FROM Categories ORDER BY CategoryName";

            dbAdapter = new SqlDataAdapter(xsql, dbConnection);
            xdset.Clear();
            dbAdapter.Fill(xdset);
            if (xdset.Tables[0].Rows.Count > 0)
            {
                cbCategoria.DataSource = xdset.Tables[0];
                cbCategoria.DisplayMember = "CategoryName";
                cbCategoria.ValueMember = "CategoryID";
            }
            else
            {
                cbCategoria.DataSource = null;
                cbCategoria.DisplayMember = "";
                cbCategoria.ValueMember = "";
            }

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            getDades();
        }
    }
}

