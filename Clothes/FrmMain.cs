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
        public static frmMain instence ;

        
        public frmMain()
        { 
            InitializeComponent();
            instence = this;
        }


        internal void frmMain_Load(string p1 , string p2)
        {
            pictureBox1.Show();
            label2.Text = p1;
            label3.Text = p2;
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

        private void txtVal_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void lbl1(object sender, EventArgs e)
        {
            //var y = Application.OpenForms["UserPro"] as UserPro;
           // y.txtUser.Text = label.Text;
        }

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}
    

