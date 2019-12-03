using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            
            InitializeComponent();
        }

        DataTable listdt = new DataTable();
         List<Login> ObjLogin = new List<Login>()
          {
           new Login { UserName = "FEAdmin" , Password ="FE@1234",Role ="Admin"  },
           new Login { UserName = "FEUser" , Password ="FE@1234",Role ="User" }
          };

         public bool IsvalidUser()
         {
             List<string> UserList = new List<string>();
             UserList = ObjLogin.Select(c => c.UserName).ToList();
             string user = string.Join(",", UserList).ToLower();

             if (user.Contains(txtUserName.Text.ToLower()))
             {
                 return true;
             }
             else
             {
                 MessageBox.Show("Please enter valid user", " Login Failed ",MessageBoxButtons.OK);
                 txtUserName.Clear();
                 txtPassword.Clear();
                 txtUserName.Focus();
                 return false;
             }
         }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
             //var role = (from a in ObjLogin where a.UserName == txtUserName.Text.Trim() select new { a.Role });
             var role = (from a in ObjLogin where (a.UserName.ToLower().Contains(txtUserName.Text.Trim().ToLower())) select a).ToList(); // -- Changes On 14/10/2019 by sriram after
             if (IsvalidUser())
             {
                 if (Convert.ToString(role[0].Role.ToLower()).Equals("admin"))
                 {
                     frmAddorSearchItems objfrmAddorSearchItems = new frmAddorSearchItems();
                     objfrmAddorSearchItems.StartPosition = FormStartPosition.CenterParent;                     
                     objfrmAddorSearchItems.Dock = DockStyle.Fill;
                     objfrmAddorSearchItems.Show();
                 }
                 else
                 {
                     frmSearch objfrmSearch = new frmSearch();
                     objfrmSearch.StartPosition = FormStartPosition.CenterParent;                     
                     objfrmSearch.Dock = DockStyle.Fill;                    
                     objfrmSearch.Show();
                 }
             }             
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
