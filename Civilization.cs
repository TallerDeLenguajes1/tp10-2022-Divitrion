// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Civilization
    {
        public int id { get; set; }
        public string name { get; set; }
        public string expansion { get; set; }
        public string army_type { get; set; }
        public List<string> unique_unit { get; set; }
        public List<string> unique_tech { get; set; }
        public string team_bonus { get; set; }
        public List<string> civilization_bonus { get; set; }

        public void show()
        {
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"nombre: {name}");
            Console.WriteLine($"expansion: {expansion}");
            Console.WriteLine($"army_type: {army_type}");
            Console.WriteLine($"unique_unit: {unique_unit}");
            Console.WriteLine($"unique_tech: {unique_tech}");
            Console.WriteLine($"team_bonus: {team_bonus}");
            Console.WriteLine($"civilization_bonus: {civilization_bonus}\n");
        }
    }

    public class Root
    {
        public List<Civilization> civilizations { get; set; }
    }