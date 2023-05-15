using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation_Manager.Models {
    public class Evaulation {
        public Activity Activity { get; set; }
        public Student Student { get; set; }
        public Teacher Evaulator { get; set; }
        public DateTime EvaulationDate { get; set; }
        public int Points { get; set; }

        public bool IsSufficientForGrade() {
            return Points >= Activity.MinPointsForGrade;
        }

        public bool IsSufficientForSignature() {
            return Points >= Activity.MinPointsForSignature;
        }


    }
}
