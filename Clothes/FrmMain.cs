using Clothes.GUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clothes
{
    public partial class frmMain : Form
    {

        //private Form currentActiveForm = null;
        //public string userName;

        

       public string userName;
        public int phone;
        public frmMain()
        { 
            InitializeComponent();
        }


        private void frmMain_Load(object sender, EventArgs e)
        {

         
            //tton.ExpandAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            string message = "are you sure?";
            string title = "Exit Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
      
        }


        private void btnShopping_Click(object sender, EventArgs e)
        {

            Form Shopping = new Inventory();
            Shopping.ShowDialog();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Form Inventory = new Inventory();
            Inventory.ShowDialog();
           // frmMain.Close();
        }

        private void btnUser_Click_1(object sender, EventArgs e)
        {

           Form UserPro = new UserPro();
            UserPro.ShowDialog();
        UserPro.Close();
        }
    }
}
    

