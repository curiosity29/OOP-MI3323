using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    class FryVisitor : IVisitor
    {
        private int type;
        public FryVisitor()
        {
            type = 2;
        }
        public int Type
        {
            get
            {
                return type;
            }
        }

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
        public string Visit(Coconut coconut)
        {
            return "Chiên rừa thành bột";
        }
        public string Visit(Chicken chicken)
        {
            return "Chiên đều trong dầu";
        }
        public string Visit(Milk milk)
        {
            throw new Exception();
        }
        public string Visit(Shrimp shrimp)
        {
            return "Bóc vỏ";
        }
        public string Visit(Taro taro)
        {
            return "Chiên giòn tan";
        }
        public string Visit(Bubble_tea bubble_Tea)
        {
            throw new Exception();
        }
        public string Visit(Tea tea)
        {
            throw new Exception();
        }
        public string Visit(Rice rice)
        {
            return "Rang cơm";
        }
        public string Visit(Beef beef)
        {
            return "Xào bò với dầu hào";
        }
    }
}
