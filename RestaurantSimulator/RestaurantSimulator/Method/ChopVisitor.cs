﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator.Method
{
    public class ChopVisitor : IVisitor
    {

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
    }
}
