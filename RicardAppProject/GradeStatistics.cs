using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RicardAppProject {

    public class GradeStatistics {
        public float AverageGrade { get; set; }
        public float HighestGrade { get; set; }
        public float LowestGrade { get; set; }
        public string HighestUser { get; set; }

        private GradeBook _book;

        public GradeStatistics(GradeBook book) {
            _book = book;
        }

        private void ComputeStatistics() {
            HighestGrade = _book.Grades.Max(x => x.Value);
            LowestGrade = _book.Grades.Min(x => x.Value);
            AverageGrade = (float)_book.Grades.Select(x => x.Value).Average();
            HighestUser = _book.Grades.FirstOrDefault(x => x.Value == HighestGrade)?.User;
        }

        public void PrintStats() {
            ComputeStatistics();

            Console.WriteLine($"---");
            Console.WriteLine($"Average grade: {AverageGrade}");
            Console.WriteLine("Highest grade: {0}", HighestGrade);
            Console.WriteLine("Lowest grade: {0}", LowestGrade);
            Console.WriteLine($"Highest user: {HighestUser}");
        }

        public void PrintStatsByUser(string username) {
            var userStats = _book.Grades.Where(grade => grade.User.ToLower() == username.ToLower());
            foreach (var stat in userStats) {
                Console.WriteLine(stat.Value);
            }
        }
    }
}
