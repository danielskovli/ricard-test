using System;
using System.Collections.Generic;
using System.Text;

namespace RicardAppProject {

    public class GradeBook {
        public string Name { get; set; }
        public List<Grade> Grades { get; set; }

        public GradeBook() {
            Grades = new List<Grade>();
        }

        public void AddGrade(Grade grade) {
            Grades.Add(grade);
        }

        public void AddGrade(float grade) {
            AddGrade(new Grade { User = "John Doe", Value = grade });
        }
    }
}
