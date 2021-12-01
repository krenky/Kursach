using System.Collections.Generic;

namespace Kursach.MVVM.Model
{
    public class Contract
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int EngineerId { get; set; }
        public Engineer Engineer { get; set; }
        public string Status { get; set; }
        public List<Component> Components { get; set; }
        public List<Service> Services { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
