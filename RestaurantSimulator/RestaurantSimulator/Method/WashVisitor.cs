using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    class WashVisitor : IVisitor
    {
        public string Visit(Fish fish)
        {
            return "Rửa sạch bằng nước ấm";
        }
        public string Visit(Coffee coffee)
        {
            return "Can't do";
        }
        public string Visit(Carrot carrot)
        {
            return "Rửa sạch bằng nước ấm";
        }
        public string Visit(Potato potato)
        {
            return "Rửa sạch bằng nước ấm";
        }
        public string Visit(Noodle noodle)
        {
            return "Rửa sạch mì bằng nước lạnh";
        }
    }
}
