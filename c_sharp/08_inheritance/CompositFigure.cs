using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_inheritance
{
    internal class CompositFigure
    {
        Figure[] figures;
        public CompositFigure(params Figure[] figures)
        {
            this.figures = figures;
        }
        public void ShowInfo()
        {
            foreach (var figure in figures)
            {
                figure.GetArea();
                figure.GetPerimeter();
            }
        }

    }
}
