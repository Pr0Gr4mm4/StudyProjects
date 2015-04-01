using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KledingWinkelFinal
{
    public partial class ucClients : UserControl
    {
        public ucClients(bool editMode)
        {
            InitializeComponent();
            txtClientID.ReadOnly = true;
            if(editMode)
            {
                // Enables editing of the selected object.

            }
            else
            {
                // locks all control to readonly
                this.txtAddressLine.ReadOnly = true;
                this.txtCityName.ReadOnly = true;
                this.txtCountryName.ReadOnly = true;
                this.txtZippCode.ReadOnly = true;
                this.btnApply.Enabled = false;
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            
        }


    }
}
