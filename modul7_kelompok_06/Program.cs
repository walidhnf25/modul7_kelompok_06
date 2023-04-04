
using Newtonsoft.Json;
using System.Text.Json;

public class TeamMembers1302210068
{
    public static void ReadJSON()
    {
        string jsonFilePath = @"E:\MOD7\modul7_kelompok_06\modul7_kelompok_06\";
        string jsonContent = File.ReadAllText(jsonFilePath);

        var members = JsonConverter.DeserializeObject<Dictionary<string, List<Dictionary<string, string>>>>(jsonContent)["member"];
        Console.WriteLine("Team member list: ");

        foreach (var member in members)
        {
            Console.WriteLine($"Anggota {members["nim"]}- {members["firstName"]} {members["lastName"]} {members["age"]} {members["gender"]}");
        }

        
    }
}
  
class program
 {
    static void Main(string[] args)
        {
            TeamMembers1302210068.ReadJSON();
        }
 }


