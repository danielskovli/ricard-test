using System;
using System.Collections.Generic;
using System.Text;

namespace RicardAppProject {
	public class Example {

        public int MyProperty { get; set; }

        public void PrintStats(GradeStatistics stats) {
            //Console.WriteLine("Average grade: {0}", stats.AverageGrade);
            Console.WriteLine($"Average grade: {stats.AverageGrade}");
            Console.WriteLine("Highest grade: {0}", stats.HighestGrade);
            Console.WriteLine("Lowest grade: {0}", stats.LowestGrade);
        }
    }
}
