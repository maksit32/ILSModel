using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILSmodel
{
    public class Plane
    {
        public int Speed { get; set; }
        public int Heingt { get; set; }
        //ILS
        public int Course { get; set; }
        //курс ВС
        public int Heading { get; set; }
        //высота принятия решения
        public int Minimum { get; set; }
    }
}
