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
    }
}
