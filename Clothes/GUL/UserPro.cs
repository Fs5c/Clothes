using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clothes.GUL
{


    public partial class UserPro : Form
    {
        public string userName;
        public int phone;
       

        public string TextBox1 { get; private set; }

        public UserPro()
        {

            InitializeComponent();
         
          
        }
      

        private void btnAddPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picUser.ImageLocation = ofd.FileName;
            }
        }

        private void UserPro_Load(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtPhone.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Enter numbers only!");
            }

        }

        private void btnloign_Click(object sender, EventArgs e)
        {

         
            
           

        }
    }
}
    



