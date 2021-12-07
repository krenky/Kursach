using System.Collections.Generic;
using System.Linq;

namespace Kursach.MVVM.Model
{
    public class Contract
    {
        List<Component> components = new List<Component>();
        List<Service> services = new List<Service>();
        public int Id { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int EngineerId { get; set; }
        public Engineer Engineer { get; set; }
        public string Status { get; set; }
        public List<Component> Components 
        { get
            {
                return components;
            } 
            set
            {
                components = value;
            } 
        }
        public List<Service> Services 
        { get
            {
                return services;
            }
            set
            {
                services = value;
            } 
        }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int Price { get
            {
                return Components.Sum(o => o.Price) + Services.Sum(o => o.Price);
            } }
    }
}
