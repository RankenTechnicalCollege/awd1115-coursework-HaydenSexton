namespace CarInventory
{
    public class Car
    {
        // primary key
        public int Id { get; set; }

        // car properties
        public string Make {  get; set; }
        public string Model { get; set; }

        public bool IsAvailable { get; set; }

        public string? Secret { get; set; }
    }
}
