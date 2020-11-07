using System;
using System.Reflection;

namespace ExamSnippets.Snippets
{
    public static class TestAssembly
    {
        public static void Run()
        {
            //DisplayAssembly();
        }

        private static void DisplayAssembly()
        {
            string assembly = Assembly.GetExecutingAssembly().ToString();
            ////string assembly = Assembly.GetAssembly(typeof(TestAssembly)).ToString();

            Console.WriteLine(assembly);
        }
    }
}
