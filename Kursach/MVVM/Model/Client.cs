using System.Collections.Generic;

namespace Kursach.MVVM.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        //public string Address { get; set; }
        ///// <summary>
        ///// Менеджер принимающий заказ
        ///// </summary>
        //public Engineer Engineer { get; set; }
        //public int EngineerId { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}
