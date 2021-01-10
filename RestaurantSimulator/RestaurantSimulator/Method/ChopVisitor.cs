using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class ChopVisitor : IVisitor
    {
        private int type;
        public ChopVisitor()
        {
            type = 1;
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
            return "Chặt cá, bỏ ra, bỏ nội tạng";
        }
        public string Visit(Coffee coffee)
        {
            return "Xay cà phê";
        }
        public string Visit(Carrot carrot)
        {
            return "Chặt cà rốt lát thành từng miếng";
        }
        public string Visit(Potato potato)
        {
            return "Thái lát thành từng miếng";
        }
        public string Visit(Noodle noodle)
        {
            return "Cắt đôi";
        }
        public string Visit(Coconut coconut)
        {
            return "Chặt lấy nước";
        }
        public string Visit(Chicken chicken)
        {
            return "Chặt thành từng khúc";
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
            return "Chặt từng khúc";
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
            throw new Exception();
        }
        public string Visit(Beef beef)
        {
            return "Thái mỏng thịt bò";
        }
    }
}
