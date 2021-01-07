using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    class FryVisitor : IVisitor
    {

        public string Visit(Fish fish)
        {
            return "Chiên cá với dầu ở 120 độ C";
        }
        public string Visit(Coffee coffee)
        {
            return "Can't do";
        }
        public string Visit(Carrot carrot)
        {
            return "Chiên cà rôt như điên";
        }
        public string Visit(Potato potato)
        {
            return "Chiên khoai tây dưới dầu ở 119 độ C";
        }
        public string Visit(Noodle noodle)
        {
            return "Chiên nhỏ lửa với nhiệt độ 90 độ C";
        }
    }
}
