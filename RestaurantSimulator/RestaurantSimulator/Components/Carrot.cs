﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSimulator
{
    public class Carrot : Component
    {
        public override string Name
        {
            get { return "Carrot"; }
        }

        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

    }
}
