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

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void overviewClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjectOverviewForm oof = new ObjectOverviewForm(1);
            oof.MdiParent = this;
            oof.Show();
        }
        private void inDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjectOverviewForm oof = new ObjectOverviewForm(2);
            oof.MdiParent = this;
            oof.Show();
        }

        private void forSaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjectOverviewForm oof = new ObjectOverviewForm(3);
            oof.MdiParent = this;
            oof.Show();
        }

        private void overviewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjectOverviewForm oof = new ObjectOverviewForm(4);
            oof.MdiParent = this;
            oof.Show();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ObjectManipulationForm omf = new ObjectManipulationForm(1,CRUDCommand.Create);
            omf.MdiParent = this;
            omf.Show();
        }

    }
}
