using System.IO;

namespace ExamSnippets.Snippets
{
    public static class TestFiles
    {
        public static void Run()
        {
            //ReadFile();
        }

        private static void ReadFile()
        {
            var fs1 = File.Open("fileName", FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);

            var fs2 = File.Open("fileName", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var fs3 = File.Open("fileName", FileMode.OpenOrCreate, FileAccess.Read, FileShare.Write);
            var fs4 = File.ReadAllLines("fileName");
            var fs5 = File.ReadAllBytes("fileName");
        }
    }
}
