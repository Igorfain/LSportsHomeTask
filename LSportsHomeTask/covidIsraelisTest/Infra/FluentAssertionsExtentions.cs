using FluentAssertions.Numeric;
using FluentAssertions.Primitives;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSportsHomeTask.covidIsraelisTest.Infra
{
    public static class FluentAssertionsExtensions
    {
        public static void Print(this AndConstraint<BooleanAssertions> na, string description)
        {
            WriteToLog(description);
        }

        public static void Print<T>(this AndConstraint<NumericAssertions<T>> na, string description) where T : struct, IComparable<T>
        {
            WriteToLog(description);
        }

        public static void Print(this AndConstraint<StringAssertions> na, string description)
        {
            WriteToLog(description);
        }

        private static void WriteToLog(string description)
        {
            ConsoleReporter.Log($"Assertion: {description} - success");
        }
    }
}
