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
         * 
         * 
         */

        

        public int FormID { get; private set; }
        public ObjectOverviewForm(int formID)
        {
            InitializeComponent();
            FormID = formID;
            switch (FormID)
            {
                case 1: // Clients
                    //overviewGridview.DataSource = kledingWinkelDataSet.OverviewCustomers;
                    
                    overviewGridview.Refresh();
                    this.Text = "Overview : Store Clients";
                    break;
                case 2: // Products
                    //overviewGridview.DataSource = kledingWinkelDataSet.OverviewClothes;
                    overviewGridview.Refresh();
                    this.Text = "Overview : Products";
                    break;
                case 3: // Products For Sale
                    //overviewGridview.DataSource = kledingWinkelDataSet.OverviewStock;
                    overviewGridview.Refresh();
                    this.Text = "Overview : Store Stock";
                    break;
                case 4: // Orders
                    //overviewGridview.DataSource = kledingWinkelDataSet.OverviewOrders;
                    overviewGridview.Refresh();
                    this.Text = "Overview : Store Orders";
                    break;
                case 5: // OrderItems

                    break;
            }

        }

        private void closeOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ObjectOverviewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kledingWinkelDataSet.OverviewStock' table. You can move, or remove it, as needed.
            //this.overviewStockTableAdapter.Fill(this.kledingWinkelDataSet.OverviewStock);
            //// TODO: This line of code loads data into the 'kledingWinkelDataSet.OverviewCustomers' table. You can move, or remove it, as needed.
            //this.overviewCustomersTableAdapter.Fill(this.kledingWinkelDataSet.OverviewCustomers);
            //// TODO: This line of code loads data into the 'kledingWinkelDataSet.OverviewClothes' table. You can move, or remove it, as needed.
            //this.overviewClothesTableAdapter.Fill(this.kledingWinkelDataSet.OverviewClothes);
            //// TODO: This line of code loads data into the 'kledingWinkelDataSet.OverviewOrders' table. You can move, or remove it, as needed.
            //this.overviewOrdersTableAdapter.Fill(this.kledingWinkelDataSet.OverviewOrders);
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
