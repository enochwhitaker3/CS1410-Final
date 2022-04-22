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
            File.WriteAllText("clothing.json", json);
        }
        public void clothingload()
        {
            var json = File.ReadAllText("clothing.json");
            clothingMemory = System.Text.Json.JsonSerializer.Deserialize<List<Clothing>>(json);
        }
        public void skatewrite()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(skateMemory);
            File.WriteAllText("skate.json", json);
        }
        public void skateload()
        {
            var json = File.ReadAllText("skate.json");
            skateMemory = System.Text.Json.JsonSerializer.Deserialize<List<Skateboarding>>(json);
        }
        public void accessorieswrite()
        {
            var json = System.Text.Json.JsonSerializer.Serialize(accessoriesMemory);
            File.WriteAllText("accessorized.json", json);
        }
        public void accessoriesload()
        {
            var json = File.ReadAllText("accessorized.json");
            accessoriesMemory = System.Text.Json.JsonSerializer.Deserialize<List<Accessories>>(json);
        }
    }
}




