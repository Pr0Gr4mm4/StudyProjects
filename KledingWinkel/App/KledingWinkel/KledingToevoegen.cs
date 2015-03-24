using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KledingWinkelLib.KledingTypes.Algemeen;
using KledingWinkelLib.KledingTypes.Jas;

namespace KledingWinkelApp
{
    public partial class KledingToevoegen : Form
    {

        private static bool jastypeSelected = false;
        private static int newProductID = 0;
        public KledingToevoegen()
        {
            InitializeComponent();
            FillComboBoxes();
            newProductID = KledingWinkelInstance.GenerateProductID;
            txtKledingStukID.Text = newProductID.ToString();
        }

        private void FillComboBoxes()
        {
            cboxSizeTypes.Items.AddRange(Enum.GetNames(typeof(KledingSize)));
            cBoxKledingTypes.Items.AddRange(Enum.GetNames(typeof(KledingType)));
            cboxSizeTypes.SelectedIndex = 0;
            cBoxKledingTypes.SelectedIndex = 0;
        }


        private void KledingToevoegen_Load(object sender, EventArgs e)
        {

        }

        // TODO: Replace Merk.A with combobox
        private void btnAddKleding_Click(object sender, EventArgs e)
        {
            // voeg kledingstuk toe aan de interne lijst.
            // Eerst ingevoerde waardes ophalen..
            string imageUrl = txtPrijs.ToString();
            decimal price = 0.00m;
            KledingSize kledingsize = (KledingSize)Enum.Parse(typeof(KledingSize), cboxSizeTypes.SelectedItem.ToString());
            KledingType kledingtype = (KledingType)Enum.Parse(typeof(KledingType), cBoxKledingTypes.SelectedItem.ToString());

            if (decimal.TryParse(txtPrijs.ToString(), out price))
            {
                if (jastypeSelected)
                {
                    JasType jastype = (JasType)Enum.Parse(typeof(JasType), cBoxJasMerken.SelectedItem.ToString());
                    //KledingWinkelInstance.jasList.Add(new KledingWinkelLib.Products.Jas(jastype, Merk.A, newProductID, imageUrl, price, kledingsize, kledingtype));
                }
                else
                {
                    string tshirttext = txtTshirtText.ToString();
                    
                    //KledingWinkelInstance.tshirtList.Add(new KledingWinkelLib.Products.Tshirt(tshirttext,newProductID, imageUrl, price, kledingsize, kledingtype));
                }
            }
            else
            {
                MessageBox.Show("Error : kan prijs niet converteren.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void cBoxKledingTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cBoxKledingTypes.SelectedItem.ToString() == KledingType.JAS.ToString())
            {
                cBoxJasMerken.Enabled = true;
                cBoxJasMerken.Items.AddRange(Enum.GetNames(typeof(KledingWinkelLib.KledingTypes.Jas.JasType)));
                cBoxJasMerken.SelectedIndex = 0;
                jastypeSelected = true;
            }
            else
            {
                jastypeSelected = false;
            }
        }

        private void cboxSizeTypes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
