using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomadApp.Models
{
    public class Order
    {
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
        public Guid ComicsId { get; set; }
        public virtual Comics Comics { get; set; }
        public bool IsDelivered { get; set; }
    }
}
