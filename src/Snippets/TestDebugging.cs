using System;

namespace ExamSnippets.Snippets
{
    public static class TestDebugging
    {
        public static void Run()
        {
            //CalculateInterest(-1, -1, -1);
        }

        private static decimal CalculateInterest(decimal loanAmount, int loanTerm, decimal loanRate)
        {
            ////Trace.Assert(loanAmount > 0);
            ////Debug.Assert(loanAmount > 0);
            decimal interestAmount = loanAmount * loanRate * loanTerm;

            Console.WriteLine("Interest calculated");

            return interestAmount;
        }
    }
}
