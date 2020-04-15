using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chaos
{
    class figure_class
    {
        public int number_of_vertices;
        public bool complete = false;
        public bool setting = false;
        public Point[] position = new Point[1];
        public int complete_point = 0;
        
        public void update()
        {
            Array.Resize(ref position, number_of_vertices);
        }
    }
}
