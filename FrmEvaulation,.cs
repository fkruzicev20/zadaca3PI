using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmEvaulation : Form {
        public FrmEvaulation() {
            InitializeComponent();
        }

        private void FrmEvaulation_Load(object sender, EventArgs e) {
            SetFormText();
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
