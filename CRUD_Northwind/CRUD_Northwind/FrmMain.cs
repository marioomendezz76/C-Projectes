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
using CRUD_Northwind.FORMULARIS;
using Microsoft.Office.Interop.Excel;


namespace CRUD_Northwind
{
    public partial class FrmMain : Form
    {
        FrmTerritoris frmTerritoris;
        FrmRegions frmRegions;
        FrmProductes frmProductes;
        SqlConnection dbConnection { get; set; }
        SqlDataAdapter dbAdapter { get; set; }
        DataSet dSet { get; set; } = new DataSet();

        String connectionString = "Data Source=DESKTOP-GSO4EB7\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        public FrmMain()
        {
            InitializeComponent();
        }

        private Boolean queJaEstaObert(String xnom)
        {
            Boolean xb = false;
            int x = 0;
            while ((x < this.MdiChildren.Length) && (this.MdiChildren[x].Name != xnom))
            {
                x++;
            }

            xb = (x < this.MdiChildren.Length);
            return xb;
        }

        private void territorisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Territoris";
            if (!queJaEstaObert(xnom))
            {
                frmTerritoris = new FrmTerritoris();
                frmTerritoris.MdiParent = this;
                frmTerritoris.Name = xnom;
                frmTerritoris.Show();
            }
            frmTerritoris.Activate();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir", "Sortir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Region";
            if (!queJaEstaObert(xnom))
            {
                frmRegions = new FrmRegions();
                frmRegions.MdiParent = this;
                frmRegions.Name = xnom;
                frmRegions.Show();
            }
            frmRegions.Activate();
        }

        private void productesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Productes";
            if (!queJaEstaObert(xnom))
            {
                frmProductes = new FrmProductes();
                frmProductes.MdiParent = this;
                frmProductes.Name = xnom;
                frmProductes.Show();
            }
            frmProductes.Activate();
        }

        private void categoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Int32 x1 = 0;
            String xsql = "SELECT * FROM Categories";
            List<string> capcaleres = new List<string>() { "ID", "Nom", "Descripció" };
            Cursor = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xcl = new Microsoft.Office.Interop.Excel.Application();

            getDades(xsql);
            iniLlibreExcel(xcl, 1);
            crearCapcaleres(xcl, capcaleres, 1);
            x1 = generarDadesExcel(xcl, capcaleres.Count(), 1);

            Cursor = Cursors.Default;
        
        }
        public void crearCapcaleres(Microsoft.Office.Interop.Excel.Application xcl, List<string> capçaleres, int num)
        {
            int i = 1;

            foreach (string s in capçaleres)
            {
                if(num==1)xcl.ActiveSheet.cells(3, i).select();
                else if(num==2) xcl.ActiveSheet.cells(1, i).select();
                xcl.ActiveCell.Formula = s;
                xcl.ActiveCell.VerticalAlignment = XlVAlign.xlVAlignCenter;
                xcl.ActiveCell.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                xcl.ActiveCell.Interior.Color = Color.MediumVioletRed;
                xcl.ActiveCell.Font.Color = Color.White;
                i++;
            }
        }

        private void iniLlibreExcel(Microsoft.Office.Interop.Excel.Application xcl, int num)
        {
            xcl.Workbooks.Add();
            xcl.Visible = true;
            xcl.Application.DisplayAlerts = true;            // si posem False no es mostrarà cap avís d'Excel ni tan sols el de tancar el llibre sense haver - lo guardat

            xcl.ActiveWorkbook.Worksheets[1].Activate();
            xcl.ActiveWorkbook.Worksheets[1].Name = "Dades";
            //
            // --- fem la capçalera ---
            //
            if (num == 1)
            {
                xcl.ActiveSheet.cells(1, 1).select();            // ens situem a la cel·la A1
                xcl.ActiveCell.Formula = "LLIBRE D\'EXCEL DE CATEGORIES";
                xcl.ActiveSheet.Range("A1:C2").Select();
                xcl.Selection.Merge();
                xcl.ActiveCell.VerticalAlignment = XlVAlign.xlVAlignCenter;
                xcl.ActiveCell.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                xcl.ActiveCell.Interior.Color = Color.BlueViolet;
                xcl.ActiveCell.Font.Color = Color.Black;

                xcl.ActiveCell.Font.Size = 12;
                xcl.ActiveCell.Font.Bold = true;
            }
        }
        private int generarDadesExcel(Microsoft.Office.Interop.Excel.Application xcl, int columnes, int num)
        {
            char ch = (char)(columnes + 64);
            int LINIA_INICIAL = 4;
            if (num == 2) LINIA_INICIAL = 2;

            int x1 = -1;
            Random R = new Random();

            //
            // --- posem les dades ---
            //
           
            foreach (DataRow fila in dSet.Tables[0].Rows)
            { 
                x1++;
                xcl.ActiveSheet.cells(LINIA_INICIAL + x1, 1).select();
                xcl.ActiveCell.Formula = fila[0].ToString();
                xcl.ActiveSheet.cells(LINIA_INICIAL + x1, 2).select();
                xcl.ActiveCell.Formula = fila[1].ToString();
                xcl.ActiveCell.NumberFormat = "dd/MM/yyyy";
                xcl.ActiveSheet.cells(LINIA_INICIAL + x1, 3).select();
                xcl.ActiveCell.Formula = fila[2].ToString();
                if(num == 2)
                {
                    xcl.ActiveSheet.cells(LINIA_INICIAL + x1, 4).select();
                    xcl.ActiveCell.Formula = fila[3].ToString();
                    xcl.ActiveSheet.cells(LINIA_INICIAL + x1, 5).select();
                    xcl.ActiveCell.Formula = fila[4].ToString();
                    xcl.ActiveSheet.cells(LINIA_INICIAL + x1, 6).select();
                    xcl.ActiveCell.Formula = fila[5].ToString();
                    xcl.ActiveSheet.cells(LINIA_INICIAL + x1, 7).select();
                    xcl.ActiveCell.Formula = Decimal.Parse(fila[6].ToString());
                }
            }

            xcl.Range["A1:" + ch.ToString() + (4 + x1).ToString().Trim()].Borders.LineStyle = XlLineStyle.xlContinuous;
            xcl.Range["A1:" + ch.ToString() + (4 + x1).ToString().Trim()].Borders.Weight = XlBorderWeight.xlThin;


            xcl.ActiveSheet.cells(1, 1).Select();

            xcl.Range["A1", "Z100"].Columns.AutoFit();
            return (x1);
        }
        private void getDades(String xsql)
        {
            if (dbConnection == null)
            {
                dbConnection = new SqlConnection(connectionString);
            }

            try
            {
                // Abre la conexión si está cerrada
                if (dbConnection.State == ConnectionState.Closed)
                {
                    dbConnection.Open();
                }

                // Configura el adaptador y llena el dataset
                dbAdapter = new SqlDataAdapter(xsql, dbConnection);
                dSet.Clear();
                dbAdapter.Fill(dSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión
                dbConnection.Close();
            }

        }
        private void ferGraficExcel(Microsoft.Office.Interop.Excel.Application xcl, Int32 x1)
        {
            Chart xgrafic;
            Range xrang, yrang;

            //
            //  --- fem el gràfic ---
            //
            xrang = xcl.ActiveSheet.Range["B2:B" + x1.ToString().Trim()];
            yrang = xcl.ActiveSheet.range["G2:G" + x1.ToString().Trim()];

            xgrafic = xcl.Charts.Add();
            xgrafic.Move(xcl.ActiveWorkbook.Worksheets[1]);
            xgrafic.Visible = XlSheetVisibility.xlSheetHidden;
            xgrafic.ChartType = XlChartType.xlLine;
            xgrafic.HasTitle = true;
            xgrafic.ChartTitle.Text = "Gràfic ordres";
            xgrafic.SetSourceData(yrang);
            xgrafic.SeriesCollection(1).name = "Segons preu";
            xgrafic.Visible = XlSheetVisibility.xlSheetVisible;

            xcl.ActiveWorkbook.Worksheets[1].Activate();
        }
        private void comandesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Int32 x1 = 0;
            String xsql = "SELECT O.OrderID, O.OrderDate, O.CustomerID, C.CompanyName, O.EmployeeID, E.FirstName, O.Freight FROM Orders O JOIN Customers C ON C.CustomerID = O.CustomerID JOIN Employees E ON O.EmployeeID = E.EmployeeID";
            List<string> capcaleres = new List<string>() { "Nº Comanda", "Data", "Id Client", "Nom Client", "Id Empleat", "Nom Empleat", "Import Total"};
            Cursor = Cursors.WaitCursor;
            Microsoft.Office.Interop.Excel.Application xcl = new Microsoft.Office.Interop.Excel.Application();

            getDades(xsql);
            iniLlibreExcel(xcl, 2);
            crearCapcaleres(xcl, capcaleres, 2); 
            x1 = generarDadesExcel(xcl, capcaleres.Count(), 2);
            ferGraficExcel(xcl, x1);
            Cursor = Cursors.Default;
        }
    }
}
