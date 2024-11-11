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
    public partial class FrmAMBProductes : Form
    {
        

        public FrmAMBProductes(Char xop, SqlConnection xdbConnection)
        {
            InitializeComponent();
            op = xop;
            dbConnection = xdbConnection;
        }
        // propietats
        SqlConnection dbConnection { get; set; }
        SqlDataAdapter dbAdapter { get; set; }
        DataSet dSet { get; set; } = new DataSet();
        Char op { get; set; } = '\0';

        // propietats corresponents als camps de la taula de la base de dades. IMPORTANT!!!! LES FEM PÚBLIQUES
        public String id { get; set; } = "";
        public String nom { get; set; } = "";
        public float preu { get; set; }
        public bool descontinuat { get; set; }

        private void FrmAMBProductes_Load(object sender, EventArgs e)
        {
            switch (op)
            {
                case 'A': this.Text = "Alta de producte"; break;
                case 'B':
                    this.Text = "Baixa de producte";
                    tbId.Text = id;
                    tbNom.Text = nom;
                    tbPreu.Text = preu.ToString();
                    tbPreu.Text = descontinuat.ToString();
                    break;
                case 'M': this.Text = "Modificacio de producte"; break;
            }
            tbId.Enabled = (op == 'A');
            tbNom.Enabled = (op != 'B');
            tbPreu.Enabled = (op != 'B');
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
                    case 'A': addProducte(); this.Close(); break;
                    case 'B': delProducte(); this.Close(); break;
                    case 'M': modProducte(); this.Close(); break;
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
                if (tbNom.Text.Trim().Length == 0)
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
        private void addProducte()
        {
            String xsql = "INSERT INTO Products (ProductID, ProductName , UnitPrice, Discontinued) VALUES(@id, @nom, @preu, @descontinuat)";

            // per a fer una operació que no sigui SELECT necessitem un objecte SqlCommand
            using (SqlCommand command = new SqlCommand(xsql, dbConnection))
            {
                // Afegim els paràmetres 
                command.Parameters.AddWithValue("@id", tbId.Text.Trim());
                command.Parameters.AddWithValue("@nom", tbNom.Text.Trim());
                command.Parameters.AddWithValue("@preu", tbPreu.Text.Trim());
                command.Parameters.AddWithValue("@descontinuat", tbDescontinuat.Text.Trim());

                // executem l'operació
                command.ExecuteNonQuery();

                // guardem l'id introduït a la propietat pública id per a que després de refrescar el DataGridView puguem seleccionar la fila en qüestió
                id = tbId.Text.Trim();
            }
        }

        private void delProducte()
        {
            String xsql = "DELETE FROM Products WHERE ProductID=@id";
            // per a fer una operació que no sigui SELECT necessitem un objecte SqlCommand
            using (SqlCommand command = new SqlCommand(xsql, dbConnection))
            {
                // Afegim els paràmetres 
                command.Parameters.AddWithValue("@id", tbId.Text.Trim());

                // executem l'operació
                command.ExecuteNonQuery();
            }
        }
        private void modProducte()
        {
            String xsql = "UPDATE Products SET ProductID = @id, ProductName = @nom, UnitPrice = @preu, Discontinued = @descontinuat WHERE TerritoryID = @id";

            using (SqlCommand command = new SqlCommand(xsql, dbConnection))
            {
                // Afegim els paràmetres 
                command.Parameters.AddWithValue("@id", tbId.Text.Trim());
                command.Parameters.AddWithValue("@nom", tbNom.Text.Trim());
                command.Parameters.AddWithValue("@preu", tbPreu.Text.Trim());
                command.Parameters.AddWithValue("@descontinuat", tbDescontinuat.Text.Trim());


                // executem l'operació
                command.ExecuteNonQuery();
            }
        }
    }
}
