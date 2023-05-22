using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
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
    public partial class FrmFinalReport : Form {
        public FrmFinalReport() {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            Close();

        }
        private List<StudentreportView> GenerateStudentReport() {
            var allStudents = StudentRepository.GetStudents();
            var examReports = new List<StudentreportView>();

            foreach (var student in allStudents) {
                if (student.HasSignature() == true) {
                    var examReport = new StudentreportView(student);
                    examReports.Add(examReport);
                }
            }
            return examReports;
        }

        private void FrmFinalReport_Load(object sender, EventArgs e) {
            var results = GenerateStudentReport();
            dgvResults.DataSource = results;

        }
    }
    }
