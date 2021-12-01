using System.Collections.Generic;

namespace Kursach.MVVM.Model
{
    public class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}
