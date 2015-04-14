using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KentekenRegistratieLib;
using KentekenRegistratieLib.Objects;
using DBHandler;

namespace libraryTester
{
    public partial class Form1 : Form
    {
        private LibraryInstance kentekenRegistratieInstance;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kentekenRegistratieInstance = new LibraryInstance(DatabaseType.MSSQL, "");
            if(kentekenRegistratieInstance.IsInitialized)
            {
                
            }
        }
    }
}
