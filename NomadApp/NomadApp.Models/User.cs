using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.Models
{
    public class User : Entity
    {
        public string FullName { get; set; }
        public bool IsSubscribed { get; set; }
        public DateTime SubsSince { get; set; }
        //public DateTime SubsUntil { get; set; }
        public int SubsYear { get; set; } 
    }
}
