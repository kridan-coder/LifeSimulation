﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Apple : Plant,
        EdibleForHuman, EdibleForDeer, EdibleForMouse, EdibleForRabbit, EdibleForPig, EdibleForRaccoon, EdibleForBear
    {
        public Apple(int _x, int _y, PlantSentry plantSentry) : base(_x, _y, plantSentry)
        {
        }

    }
}
