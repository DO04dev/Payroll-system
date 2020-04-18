using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region Get Login Details
            Connection con = new Connection();
            con.dataGet("Select * from tblUser where UserName = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'");

            DataTable dt = new DataTable();
            con.sda.Fill(dt);

            #region Verify login Details
            if (dt.Rows.Count > 0)
            {
                this.Hide();
                frmMain frm = new frmMain();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Invalid UserName or Password...!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            
            #endregion
        }

    }
}
