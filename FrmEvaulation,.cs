using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluation_Manager.Repositories;

namespace Evaluation_Manager {
    public partial class FrmEvaulation : Form {
        private Student student;

        public Student SelectedStudent { get=> student; set=> student =value; }

        public FrmEvaulation(Student  selectedStudent) {
            InitializeComponent();
            student = selectedStudent;
        }

        private void FrmEvaulation_Load(object sender, EventArgs e) {
            SetFormText();
            var activities = ActivityRepository.GetActivities();
            cboActivities.DataSource = activities;
        }

        private void SetFormText()
        {
            Text= student.FirstName + " " + student.LastName;
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) {
            var currentActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity.MaxPoints;
            txtMinForSignature.Text = currentActivity.MinPointsForSignature + "/" + currentActivity.MaxPoints;
            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoints;

            var evaulation = EvaulationRepository.GetEvaluation(SelectedStudent, currentActivity);
            if (evaulation != null) {
                txtTeacher.Text=evaulation.Evaulator.ToString();
                txtEvaulationDate.Text=evaulation.EvaulationDate.ToString();
                numPoints.Value = evaulation.Points;
            } else {
                txtTeacher.Text=FrmLogin.LoggedTeacher.ToString();
                txtEvaulationDate.Text = " ";
                numPoints.Value = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            var activity=cboActivities.SelectedItem as Activity;
            var teacher = FrmLogin.LoggedTeacher;

            int points=(int)numPoints.Value;

            teacher.PerformEvaulation(SelectedStudent, activity, points);
            Close();
        }
    }
}
