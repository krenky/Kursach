using System.Collections.Generic;

namespace Kursach.MVVM.Model
{
    public class Engineer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Login { get; set; }
        public string? Password { get; set; }
        public List<Contract> Contracts { get; set; }
        //public List<Client> Clients { get; set; }
    }
}
