using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models {
    public class StudentreportView {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string K1 { get; set; }
        public string K2 { get; set; }
        public string Z1 { get; set; }
        public string Z2 { get; set; }
        public string Z3 { get; set; }
        public string HasSignature { get; set; }
        public string HasGrade { get; set; }
        public int TotalPoints { get; set; }
        public int Grade { get; set; }

        public StudentreportView(Student student) { 
            FirstName = student.FirstName;
            LastName = student.LastName;

            HasSignature = student.HasSignature() == true ? "DA" : "NE";
            HasGrade = student.HasGrade() == true ? "DA" : "NE";

            TotalPoints = student.CalculateTotalPoints();
            Grade=student.CalculateGrade();

            var evaulations =student.GetEvaulations();
            var kolokvij1 = evaulations.FirstOrDefault(e => e.Activity.Name == "Kolokvij 1");
            var kolokvij2 = evaulations.FirstOrDefault(e => e.Activity.Name == "Kolokvij 2");
            var zadaca1 = evaulations.FirstOrDefault(e => e.Activity.Name == "Zadaca 1");
            var zadaca2 = evaulations.FirstOrDefault(e => e.Activity.Name == "Zadaca 2");
            var zadaca3 = evaulations.FirstOrDefault(e => e.Activity.Name == "Zadaca 3");

            K1=kolokvij1==null ? "-" : kolokvij1.Points.ToString();
            K2= kolokvij2 == null ? "-" : kolokvij2.Points.ToString();
            Z1 = zadaca1 == null ? "-" : zadaca1.Points.ToString();
            Z2 = zadaca3 == null ? "-" : zadaca3.Points.ToString();
            Z3 = zadaca1 == null ? "-" : zadaca1.Points.ToString();

        }

    }
}
