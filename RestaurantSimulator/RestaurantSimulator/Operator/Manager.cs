using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Manager
    {

        public Form_Refrigerator refrigerator;

        public static Manager TheManager { get; internal set; }

        public void AđdSupply(ICollection<Component> list)
        {
            throw new NotImplementedException();
        }

        public List<Component> GetComponents(List<Component> component_List)
        {
            throw new NotImplementedException();
        }
    }
}
