﻿using Evaluation_Manager.Models;
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
        private Student student;
        public FrmEvaulation(Repositories.StudentRepository selectedStudent) {
            InitializeComponent();
            student = selectedStudent;
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
