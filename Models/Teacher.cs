using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models
{
    public class Teacher : Person {
        public string Username { get; set; }
        public string Password { get; set; }

        public bool CheckPassword(string password) {
            return Password == password;
        }

        public void PerformEvaulation(Student student, Activity activity, int points) {
            var evaulation = EvaulationRepository.GetEvaluation(student, activity);
            if (evaulation == null) {
                EvaulationRepository.InsertEvaulation(student, activity, this, points);
            } else {
                EvaulationRepository.UpdateEvaulation(evaulation, this, points);
            }
        }
    }
}
