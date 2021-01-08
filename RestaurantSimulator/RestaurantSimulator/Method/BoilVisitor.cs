using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class BoilVisitor : IVisitor
    {
        private int type;
        public BoilVisitor()
        {
            type = 4;
        }
        public int Type
        {
            get
            {
                return type;
            }
        }
        public string Visit(Tea tea)
        {
            return "Đun trà kiểu Cholepski";
        }
        public string Visit(Bubble_tea bubble_tea)
        {
            return "Cho vào nước làm sôi đến 100 độ C rồi dừng";
        }
        public string Visit(Taro taro)
        {
            return "Đun khi nào mềm thì dừng";
        }
        public string Visit(Milk milk)
        {
            return "Đun trà kiểu Lewandoski";
        }
        public string Visit(Coconut coconut)
        {
            throw new Exception();
        }

        public string Visit(Chicken chicken)
        {
            return "Luộc gà trong nước sôi 20 phút";
        }
        public string Visit(Fish fish)
        {
            return "Đun trong nước sôi nhỏ lửa 20 phút";
        }
        public string Visit(Shrimp shrimp)
        {
            return "Đun tầm 5 phút thì dừng";
        }

        public string Visit(Coffee coffee)
        {
            return "Pha coffee với nước sôi khoảng 100 độ C";
        }
        public string Visit(Carrot carrot)
        {
            return "Luộc chín carrot trong 10 phút";
        }
        public string Visit(Potato potato)
        {
            return "Luộc chín khoai tây trong 5 phút";
        }
        public string Visit(Noodle noodle)
        {
            return "Làm mềm mì trong nước sôi 100 độ C";
        }
        public string Visit(Rice rice)
        {
            return "Nấu gạo vưa đủ nước";
        }
    }
}
