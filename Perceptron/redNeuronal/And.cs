using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redNeuronal
{
    class And
    {
        public double x1 { get; set; }
        public double x2 { get; set; }
        public double x3 { get; set; }
        public double dx { get; set; }

        public And(double x1, double x2, double x3, double dx)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.dx = dx;

        }
    }
}
