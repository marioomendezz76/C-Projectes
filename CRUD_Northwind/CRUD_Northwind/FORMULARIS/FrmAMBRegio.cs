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
    public partial class FrmAMBRegio : Form
    {
        // propietats
        SqlConnection dbConnection { get; set; }
        SqlDataAdapter dbAdapter { get; set; }
        DataSet dSet { get; set; } = new DataSet();
        Char op { get; set; } = '\0';

        // propietats corresponents als camps de la taula de la base de dades. IMPORTANT!!!! LES FEM PÚBLIQUES
        public String id { get; set; } = "";
        public String descripcio { get; set; } = "";

        public FrmAMBRegio(Char xop, SqlConnection xdbConnection)
        {
            InitializeComponent();
            op = xop;
            dbConnection = xdbConnection;
        }
        
        private void FrmAMBRegio_Load(object sender, EventArgs e)
        {
            switch (op)
            {
                case 'A': this.Text = "Alta de regió"; break;
                case 'B':
                    this.Text = "Baixa de regió";
                    tbId.Text = id;
                    tbDesc.Text = descripcio;
                    break;
                case 'M': this.Text = "Modificacio de regió"; break;
            }
            tbId.Enabled = (op == 'A');
            tbDesc.Enabled = (op != 'B');
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
                    case 'A': addRegio(); this.Close(); break;
                    case 'B': delRegio(); this.Close(); break;
                    case 'M': modRegio(); break;
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
        private void addRegio()
        {
            String xsql = "INSERT INTO Region (RegionID, RegionDescription) VALUES(@id, @desc)";

            // per a fer una operació que no sigui SELECT necessitem un objecte SqlCommand
            using (SqlCommand command = new SqlCommand(xsql, dbConnection))
            {
                // Afegim els paràmetres 
                command.Parameters.AddWithValue("@id", tbId.Text.Trim());
                command.Parameters.AddWithValue("@desc", tbDesc.Text.Trim());

                // executem l'operació
                command.ExecuteNonQuery();

                // guardem l'id introduït a la propietat pública id per a que després de refrescar el DataGridView puguem seleccionar la fila en qüestió
                id = tbId.Text.Trim();
            }
        }
        private void delRegio()
        {
            String xsql = "DELETE FROM Region WHERE RegionID=@id";
            // per a fer una operació que no sigui SELECT necessitem un objecte SqlCommand
            using (SqlCommand command = new SqlCommand(xsql, dbConnection))
            {
                // Afegim els paràmetres 
                command.Parameters.AddWithValue("@id", tbId.Text.Trim());

                // executem l'operació
                command.ExecuteNonQuery();
            }
        }
        private void modRegio()
        {
            String xsql = "UPDATE Region SET RegionDescription = @desc WHERE RegionID = @id";
            // per a fer una operació que no sigui SELECT necessitem un objecte SqlCommand
            using (SqlCommand command = new SqlCommand(xsql, dbConnection))
            {
                // Afegim els paràmetres 
                command.Parameters.AddWithValue("@id", tbId.Text.Trim());
                command.Parameters.AddWithValue("@desc", tbDesc.Text.Trim());


                // executem l'operació
                command.ExecuteNonQuery();
            }
        }
    }
}
