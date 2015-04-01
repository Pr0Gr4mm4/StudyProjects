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
    public partial class KledingWinkelMainForm : Form
    {
        public KledingWinkelMainForm()
        {
            InitializeComponent();
        }

        #region Menu

        #region Overviews
        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void overviewClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KledingWinkelInstance.ActiveMdiChildID = 1;
            KledingWinkelInstance.ActiveMdiChildTree.Add(1);
            ObjectOverviewForm oof = new ObjectOverviewForm(1);
            oof.MdiParent = this;
            oof.Show();
        }
        private void inDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KledingWinkelInstance.ActiveMdiChildID = 2;
            KledingWinkelInstance.ActiveMdiChildTree.Add(2);
            ObjectOverviewForm oof = new ObjectOverviewForm(2);
            oof.MdiParent = this;
            oof.Show();
        }
        private void forSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KledingWinkelInstance.ActiveMdiChildID = 3;
            KledingWinkelInstance.ActiveMdiChildTree.Add(3);
            ObjectOverviewForm oof = new ObjectOverviewForm(3);
            oof.MdiParent = this;
            oof.Show();
        }
        private void overviewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KledingWinkelInstance.ActiveMdiChildID = 4;
            KledingWinkelInstance.ActiveMdiChildTree.Add(4);
            ObjectOverviewForm oof = new ObjectOverviewForm(4);
            oof.MdiParent = this;
            oof.Show();
        }
        #endregion

        #region Manipulation Forms
        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjectManipulationForm omf = new ObjectManipulationForm(1,CRUDCommand.Create);
            omf.MdiParent = this;
            omf.Show();
        }


        #endregion

        #region Exit and Close
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cascadeCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region ActiveChild switch
            switch (KledingWinkelInstance.ActiveMdiChildID)
            {
                case 1:
                    foreach(Form f in this.MdiChildren)
                    {
                        if(f.Text.ToLower().Contains("client"))
                        {
                            f.Close();
                        }
                    }
                    break;
                case 2:
                    foreach (Form f in this.MdiChildren)
                    {
                        if (f.Text.ToLower().Contains("product"))
                        {
                            f.Close();
                        }
                    }
                    break;
                case 3:
                    foreach (Form f in this.MdiChildren)
                    {
                        if (f.Text.ToLower().Contains("stock"))
                        {
                            f.Close();
                        }
                    }
                    break;
                case 4:
                    foreach (Form f in this.MdiChildren)
                    {
                        if (f.Text.ToLower().Contains("order"))
                        {
                            f.Close();
                        }
                    }
                    break;
            }
            #endregion

            KledingWinkelInstance.ActiveMdiChildTree.Remove(KledingWinkelInstance.ActiveMdiChildID);
            KledingWinkelInstance.ActiveMdiChildID = KledingWinkelInstance.ActiveMdiChildTree.First();
        }
        private void closeAllWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }
        #endregion

        #endregion
    }
}
