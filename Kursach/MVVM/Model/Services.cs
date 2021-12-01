using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Kursach.MVVM.Model
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public List<Contract> Contracts { get; set; }

    }
}
