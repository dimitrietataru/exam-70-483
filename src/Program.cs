using ExamSnippets.Snippets;
using System;

namespace ExamSnippets
{
    public class Program
    {
        public static void Main(string[] _)
        {
            TestAssembly.Run();
            TestDebugging.Run();
            TestEventsDelegatesCallbacks.Run();
            TestFiles.Run();
            TestLanguageTypes.Run();
            TestLoggingExceptions.Run();
            TestOop.Run();
            TestSerializers.Run();
            TestThreadingTasks.Run();

            Console.ReadKey();
        }
    }
}
