using clothing;
using skateboarding;
using accessories;
namespace storage
{

    public class StorageService
    {
        public List<Clothing> clothingMemory = new List<Clothing>();
        public List<Skateboarding> skateMemory = new List<Skateboarding>();
        public List<Accessories> accessoriesMemory = new List<Accessories>();

        public void clothingwrite()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(clothingMemory);
            File.WriteAllText("text.json", json);
        }
        public void clothingload()
        {
            var json = File.ReadAllText("text.json");
            clothingMemory = System.Text.Json.JsonSerializer.Deserialize<List<Clothing>>(json);
        }
        public void skatewrite()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(clothingMemory);
            File.WriteAllText("text.json", json);
        }
        public void skateload()
        {
            var json = File.ReadAllText("text.json");
            clothingMemory = System.Text.Json.JsonSerializer.Deserialize<List<Clothing>>(json);
        }
        public void accessorieswrite()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(clothingMemory);
            File.WriteAllText("text.json", json);
        }
        public void accessoriesload()
        {
            var json = File.ReadAllText("text.json");
            clothingMemory = System.Text.Json.JsonSerializer.Deserialize<List<Clothing>>(json);
        }
    }
}




