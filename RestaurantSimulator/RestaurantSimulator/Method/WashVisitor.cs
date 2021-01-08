using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    class WashVisitor : IVisitor
    {
        private int type;
        public WashVisitor()
        {
            type = 3;
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
        public string Visit(Coconut coconut)
        {
            return "Chặt lấy nước";
        }
        public string Visit(Chicken chicken)
        {
            return "Rửa sạch lông";
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
        public string Visit(Rice rice)
        {
            return "Vo gạo";
        }
        public string Visit(Tea tea)
        {
            return "Rưa qua lân nước";
        }
    }
}
