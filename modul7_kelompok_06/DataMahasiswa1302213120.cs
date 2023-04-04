using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_06
{
    public class DataMahasiswa1302213120
    {
        public DataMahasiswa1302213120()
        {

        }
        public static void ReadJSON()
        {
            try
            {
                string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
                string jsonString = File.ReadAllText(path + "/jurnal7_1_1302213120.json");
                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true
                };
                var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302213120>(jsonString, options);
                Console.WriteLine($"First Name: {dataMahasiswa.firstName}");
                Console.WriteLine($"Last Name: {dataMahasiswa.lastName}");
                Console.WriteLine($"Gender: {dataMahasiswa.gender}");
                Console.WriteLine($"Age: {dataMahasiswa.age}");
                Console.WriteLine($"Street Address: {dataMahasiswa.address.streetAddress}");
                Console.WriteLine($"City: {dataMahasiswa.address.city}");
                Console.WriteLine($"State: {dataMahasiswa.address.state}");
                Console.WriteLine("Courses:");
                foreach (var course in dataMahasiswa.courses)
                {
                    Console.WriteLine($"- Code: {course.code}, Name: {course.name}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
            catch (JsonException)
            {
                Console.WriteLine("Invalid JSON format.");
            }
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public Course[] courses { get; set; }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class Course
        {
            public string code { get; set; }
            public string name { get; set; }
        }
    }

}
