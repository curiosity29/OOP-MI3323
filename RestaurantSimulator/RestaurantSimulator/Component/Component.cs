using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{

    public class Component
    {
        public List<IVisitor> visitors = new List<IVisitor>();
        public string Name { get; set; }
<<<<<<< Updated upstream
        public string Status { get; set; }
        public abstract string Accept(IVisitor visitor);
=======
        public int Quantity { get; set; }
>>>>>>> Stashed changes
    }
    
}
