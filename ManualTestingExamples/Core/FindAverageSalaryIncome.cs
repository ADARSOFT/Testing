using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualTestingExamples.Core
{
    public static class FindAverageSalaryIncome
    {
        public static decimal Last3Income(List<Salary> salaries)
        {
            return salaries.OrderByDescending(p=> p.Date).Take(3).Average( p => p.Amount);
        }
    }

    public class Salary
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
