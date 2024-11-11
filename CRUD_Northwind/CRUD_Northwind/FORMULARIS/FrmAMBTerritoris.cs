using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Northwind.FORMULARIS
{
    public partial class FrmAMBTerritoris : Form
    {
        // propietats
        SqlConnection dbConnection { get; set; }
        SqlDataAdapter dbAdapter { get; set; }
        DataSet dSet { get; set; } = new DataSet();
        Char op { get; set; } = '\0';

        // propietats corresponents als camps de la taula de la base de dades. IMPORTANT!!!! LES FEM PÚBLIQUES
        public String id { get; set; } = "";
        public String descripcio { get; set; } = "";
        public int idRegio { get; set; }


        public FrmAMBTerritoris(Char xop, SqlConnection xdbConnection)
        {
            InitializeComponent();
            op = xop;
            dbConnection = xdbConnection;
        }

        private void FrmAMBTerritoris_Load(object sender, EventArgs e)
        {
            switch (op)
            {
                case 'A': this.Text = "Alta de territori"; break;
                case 'B':
                    this.Text = "Baixa de territori";
                    tbId.Text = id;
                    tbDesc.Text = descripcio;
                    cbRegions.SelectedValue = idRegio;
                    break;
                case 'M': this.Text = "Modificacio de territori"; break;
            }
            omplirComboRegions();
            tbId.Enabled = (op == 'A');
            tbDesc.Enabled = (op != 'B');
            cbRegions.Enabled = (op != 'B');
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (verificarDades())
            {
                switch (op)
                {
                    case 'A': addTerritori(); this.Close(); break;
                    case 'B': delTerritori(); this.Close(); break;
                    case 'M': modTerritori(); this.Close(); break;
                }
            }
        }

        private Boolean verificarDades()
        {
            Boolean xb = false;
            if (tbId.Text.Trim().Length == 0)
            {
                MessageBox.Show("L'identificador no pot estar buid", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tbDesc.Text.Trim().Length == 0)
                {
                    MessageBox.Show("La descripcio no pot estar buida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    xb = true;
                }
            }
            return xb;
        }
        private void addTerritori()
        {
            String xsql = "INSERT INTO Territories (TerritoryID, TerritoryDescription, RegionID) VALUES(@id, @desc, @regio)";

            // per a fer una operació que no sigui SELECT necessitem un objecte SqlCommand
            using (SqlCommand command = new SqlCommand(xsql, dbConnection))
            {
                // Afegim els paràmetres 
                command.Parameters.AddWithValue("@id", tbId.Text.Trim());
                command.Parameters.AddWithValue("@desc", tbDesc.Text.Trim());
                command.Parameters.AddWithValue("@regio", cbRegions.SelectedValue);

                // executem l'operació
                command.ExecuteNonQuery();

                // guardem l'id introduït a la propietat pública id per a que després de refrescar el DataGridView puguem seleccionar la fila en qüestió
                id = tbId.Text.Trim();
            }
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

        private void delTerritori()
        {
            String xsql = "DELETE FROM Territories WHERE TerritoryID=@id";
            // per a fer una operació que no sigui SELECT necessitem un objecte SqlCommand
            using (SqlCommand command = new SqlCommand(xsql, dbConnection))
            {
                // Afegim els paràmetres 
                command.Parameters.AddWithValue("@id", tbId.Text.Trim());

                // executem l'operació
                command.ExecuteNonQuery();
            }
        }
        private void modTerritori()
        {
            String xsql = "UPDATE Territories SET TerritoryDescription = @desc, RegionID = @regio WHERE TerritoryID = @id";

            using (SqlCommand command = new SqlCommand(xsql, dbConnection))
            {
                // Afegim els paràmetres 
                command.Parameters.AddWithValue("@id", tbId.Text.Trim());
                command.Parameters.AddWithValue("@desc", tbDesc.Text.Trim());
                command.Parameters.AddWithValue("@regio", cbRegions.SelectedValue);

                // executem l'operació
                command.ExecuteNonQuery();
            }
        }
    }
}
