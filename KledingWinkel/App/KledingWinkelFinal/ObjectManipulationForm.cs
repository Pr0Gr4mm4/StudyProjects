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
    public partial class ObjectManipulationForm : Form
    {
        private int sysID = 0;
        
        public ObjectManipulationForm(int sysid, CRUDCommand crudcmd)
        {
            InitializeComponent();
            if (sysid != 0 && sysid <= 3)
            {
                sysID = sysid; // later maybe needed
                
                // Determine which labels to use
                switch (sysid)
                {
                    case 1: // clients
                        ucClients ucclients = new ucClients(false);
                        ucclients.Parent = tabClientManipulation;
                        InitializeManipulationFormTitle(crudcmd);
                        ucclients.Show();
                        tabProductManipulation.Hide();
                        tabOrderManipulation.Hide();
                        tabOrderItemManipulation.Hide();
                        break;
                    case 2: // products
                        tabClientManipulation.Hide();
                        tabOrderManipulation.Hide();
                        tabOrderItemManipulation.Hide();
                        break;
                    case 3: // orders
                        tabClientManipulation.Hide();
                        tabProductManipulation.Hide();
                        tabOrderItemManipulation.Hide();
                        break;
                    case 4: // order items
                        tabClientManipulation.Hide();
                        tabProductManipulation.Hide();
                        tabOrderManipulation.Hide();
                        break;
                }
            }
        }

        private void InitializeManipulationFormTitle(CRUDCommand crudcmd)
        {
            switch (crudcmd)
            {
                case CRUDCommand.Select:
                    break;
                case CRUDCommand.Update:
                    this.Text = "Clients : Update client";
                    break;
                case CRUDCommand.Create:
                    this.Text = "Clients : Add new client";
                    break;
                case CRUDCommand.Remove:
                    this.Text = "Clients : Remove client";
                    break;
            }
        }
        private void ObjectManipulationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void tabClientManipulation_Click(object sender, EventArgs e)
        {

        }
    }
}
