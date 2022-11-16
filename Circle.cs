using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_IngrassiaSamuele_Figure
{
    public class Circle : Shape
    {
        double radius;
        public Circle (double radius)
        {
            name = "Cerchio";

            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }


        public override double Perimeter
        {
            get
            {
                return radius * 2 * Math.PI;
            }
        }
    }
}
