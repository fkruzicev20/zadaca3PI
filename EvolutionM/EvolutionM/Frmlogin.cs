using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvolutionM {
    public partial class Frmlogin : Form {
        string username = "nastavnik";
        string password = "test";
        public Frmlogin() {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e) {
            if (txtusername.Text == "") {
                MessageBox.Show("Korisnicko ime nije uneseno","Problem",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txtpassword.Text == ""){
                MessageBox.Show("Lozinka nije unesena", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else { 
                if (txtusername.Text == username && txtpassword.Text == password) {
                    MessageBox.Show("Dobrodosli", "Prijavljeni ste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else{
                       MessageBox.Show("Krivi podaci", "Niste prijavljeni", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
