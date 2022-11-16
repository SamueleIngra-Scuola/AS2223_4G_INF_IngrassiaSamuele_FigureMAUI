using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_IngrassiaSamuele_Figure
{
    public class Shape
    {
        int edges;
        protected string name;

        public Shape()
        {
            edges = 0;
            name = "Figura Geometrica";
        }

        public virtual double Area
        {
            get
            {
                return 0;
            }
        }
        public virtual double Perimeter
        {
            get
            {
                return 0;
            }
        }
    }
}
