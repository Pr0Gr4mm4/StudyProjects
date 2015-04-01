using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KledingWinkelApp.Users;

namespace KledingWinkelApp
{
    public partial class Form1 : Form
    {

        private List<User> userList = new List<User>();

        public Form1()
        {
            InitializeComponent();
            InitializeInternalDB();
            userList.Add(new User("admin", "admin", true));
            userList.Add(new User("user1", "user1", false));
            userList.Add(new User("user2", "user2", false));
        }

        private void btnKledingStukToevoegen_Click(object sender, EventArgs e)
        {
            Form f = new KledingToevoegen();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KledingWinkelLib.Objects.Customer c = new KledingWinkelLib.Objects.Customer("voornaam", "achternaam", new KledingWinkelLib.Objects.Shipping("adres",33, "stad", "land", "postcode"));
            txtUserOutPutTest.Text = c.Shipping.ToString();
        }

        private void InitializeInternalDB()
        {
            // Inject information or read from file
        }

        private void btnTestSqlConnection_Click(object sender, EventArgs e)
        {
            KledingWinkelLib.DBHandler handler = new KledingWinkelLib.DBHandler(@"Server=localhost\SYNSERNET;Database=KledingWinkel;User ID=KledingWinkelAppl; Password=kledingwinkel");
            try
            {
                // WIP
                KledingWinkelLib.OrderManager.Order orderTest = new KledingWinkelLib.OrderManager.Order(1);
                orderTest.AddProductToOrder(new KledingWinkelLib.Products.Tshirt("hello world", 1, "NULL", 12.95m, KledingWinkelLib.KledingTypes.Algemeen.KledingSize.S,
                    KledingWinkelLib.KledingTypes.Algemeen.KledingType.TSHIRT, KledingWinkelLib.KledingTypes.Algemeen.Merk.A, 5, true), 2);
                orderTest.AddProductToOrder(new KledingWinkelLib.Products.Jas(KledingWinkelLib.KledingTypes.Jas.JasType.Herfst,
                    KledingWinkelLib.KledingTypes.Algemeen.Merk.A, 2, "", 24.95m, KledingWinkelLib.KledingTypes.Algemeen.KledingSize.M,
                    KledingWinkelLib.KledingTypes.Algemeen.KledingType.JAS, 25, true),2);
                
                handler.SqlInsert("CustomerOrder",orderTest);



                // WORKS
                //handler.SqlInsert("KledingStuk", new KledingWinkelLib.Products.Jas(KledingWinkelLib.KledingTypes.Jas.JasType.Herfst, 
                //    KledingWinkelLib.KledingTypes.Algemeen.Merk.E, 22, "", 55.55m, KledingWinkelLib.KledingTypes.Algemeen.KledingSize.XXL, 
                //    KledingWinkelLib.KledingTypes.Algemeen.KledingType.JAS, 25, true));

                // WORKS
                //handler.SqlInsert("KledingStuk", new KledingWinkelLib.Products.Tshirt("hello world",1,"NULL",22.34m, KledingWinkelLib.KledingTypes.Algemeen.KledingSize.S, 
                //    KledingWinkelLib.KledingTypes.Algemeen.KledingType.TSHIRT, KledingWinkelLib.KledingTypes.Algemeen.Merk.A, 5,true ));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputName = textBox1.Text;
            string inputPass = textBox2.Text;
            bool flag = false;

            if (inputName != "" && inputPass != "")
            {
                foreach (User usr in userList)
                {
                    if (usr.Name == inputName && usr.Pass == inputPass)
                    {
                        flag = true;
                        if (usr.IsAdmin)
                        {
                            // adminpanel
                        }
                        else
                        {
                            // userpanel
                        }
                    }
                }
            }

            if(!flag)
            {
                MessageBox.Show("Incorrect login credentials.");
            }
        }
    }
}
