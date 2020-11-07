using System;
using System.Globalization;

namespace ExamSnippets.Snippets
{
    public static class TestLanguageTypes
    {
        public static void Run()
        {
            //Calculate(10.20f);
            //ParseDate();
        }

        public static void Calculate(float amount)
        {
            object amountRef = amount;
            int balance = (int)(float)amountRef;
            Console.WriteLine(balance);
        }

        public static void ParseDate()
        {
            string inputDate = "2020-01-01T12:00:00+02:00";
            DateTime validatedDate;

            bool validDate = DateTime.TryParse(inputDate, CultureInfo.CurrentCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal, out validatedDate);

            Console.WriteLine(validatedDate);
        }
    }
}
