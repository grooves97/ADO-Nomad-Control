using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.Models
{
    public class Comics : Entity
    {
        public string Name { get; set; }
        public DateTime AddDate { get; set; }
    }
}
