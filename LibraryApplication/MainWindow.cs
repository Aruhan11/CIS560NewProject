using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryApplication
{
    public partial class uxMainWindow : Form
    {
        public uxMainWindow()
        {
            InitializeComponent();
        }

        private void uxUserManageButton_Click(object sender, EventArgs e)
        {
            ManageUserWindow u = new ManageUserWindow();
            u.Show();
        }

        private void uxCreatorManageButton_Click(object sender, EventArgs e)
        {
            ManageCreatorWindow c = new ManageCreatorWindow();
            c.Show();
        }

        private void uxAssetManageButton_Click(object sender, EventArgs e)
        {
            ManageAssetWindow a = new ManageAssetWindow();
            a.Show();
        }

        private void uxCheckOutAssetManageButton_Click(object sender, EventArgs e)
        {
            ManageCheckOutAssetWindow coa = new ManageCheckOutAssetWindow();
            coa.Show();
        }

        private void uxLibrarianManageButton_Click(object sender, EventArgs e)
        {
                
        }

        private void uxMainWindow_Load(object sender, EventArgs e)
        {

        }

        private void uxQuitButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
