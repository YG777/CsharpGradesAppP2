using System.IO;

namespace Grades
{
    internal interface IGradesTracker
    {

         void AddGrade(float grade);
         GradeStatistics ComputeStatistics();
         void WriteGrades(TextWriter destination);
         string Name { get; set; }
    }
}