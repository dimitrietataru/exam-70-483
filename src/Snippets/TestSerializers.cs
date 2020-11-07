using System.Runtime.Serialization;

namespace ExamSnippets.Snippets
{
    public static class TestSerializers
    {
        public static void Run()
        {
            //_ = ConvertToName("");
            //DoWork();
        }

        private static Name ConvertToName(string json)
        {
            ////var ser = new JavaScriptSerializer();
            ////return ser.Deserialize<Name>(json);

            return default;
        }

        private static void DoWork()
        {
            ////var location = new Location { Label = "Test", Direction = Compass.West };
            ////Console.WriteLine(WriteObject(location,
            ////    new DataContractJsonSerializer(typeof(Location))));
        }
    }

    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int[] Values { get; set; }
    }

    public enum Compass
    {
        North,
        South,
        East,
        West
    }

    [DataContract]
    public class Location
    {
        [DataMember]
        public string Label { get; set; }
        [DataMember]
        public Compass Direction { get; set; }
    }
}
