﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_inheritance
{
    internal class CompositFigure
    {
        public CompositFigure(params Figure[] figures)
        {
            foreach (var figure in figures)
            {
                figure.GetArea();
            }

        }
    }
}
