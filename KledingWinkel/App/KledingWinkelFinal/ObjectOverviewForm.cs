using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KledingWinkelFinal
{
    public partial class ObjectOverviewForm : Form
    {
        /* Form IDs:
         * Form IDs are based on the formtype. Which means each form type has it's own form IDs.
         */
        public int FormID { get; private set; }
        public ObjectOverviewForm(int formID)
        {
            InitializeComponent();
            FormID = formID;
            DataTable dt = null;
            string procedureName = "";
            switch (FormID)
            {
                case 1: // Clients
                    procedureName = "OverviewCustomers";
                    this.Text = "Overview : Store Clients";
                    break;
                case 2: // Products
                    procedureName= "OverviewClothes";
                    this.Text = "Overview : Products";
                    break;
                case 3: // Products For Sale
                    procedureName= "OverviewStock";
                    this.Text = "Overview : Store Stock";
                    break;
                case 4: // Orders
                    procedureName ="OverviewOrders";
                    this.Text = "Overview : Store Orders";
                    break;
                case 5: // OrderItems

                    break;
            }

            // Convert the datatable to a gridview
            overviewGridview.AutoGenerateColumns = false;
            ConvertToGridView(KledingWinkelInstance.databaseHandler.GetOverView(procedureName));
        }
        private void ConvertToGridView(DataTable dt)
        {
            foreach (DataColumn dc in dt.Columns)
            {
                overviewGridview.Columns.Add(dc.ColumnName, dc.Caption);
            }
            foreach (DataRow dr in dt.Rows)
            {
                overviewGridview.Rows.Add(dr.ItemArray);
            }
        }
        private void closeOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ObjectOverviewForm_Load(object sender, EventArgs e)
        {
        }
        private void btnOverviewSelected_Click(object sender, EventArgs e)
        {
            ObjectOverviewForm oof = new ObjectOverviewForm(5);
            oof.MdiParent = this.MdiParent;
            oof.Show();
        }
    }

    public enum FormType
    {
        Overview,
        Manipulation
    }
    public enum CRUDCommand
    {
        Select =1,
        Update =2,
        Create =3,
        Remove =4
    }
}
