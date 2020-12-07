using System;
using System.Collections.Generic;

namespace RicardAppProject {
    class Program {

        static void Main(string[] args) {


            GradeBook book = new GradeBook();
            book.AddGrade(new Grade { User = "Ricard", Value = 91 });
            book.AddGrade(new Grade { User = "Ricard", Value = 85 });
            book.AddGrade(89.5f);
            book.AddGrade(87f);

            var stats = new GradeStatistics(book);
            stats.PrintStats();
            Console.WriteLine("----");
            stats.PrintStatsByUser("Ricard");
        }
    }
}
