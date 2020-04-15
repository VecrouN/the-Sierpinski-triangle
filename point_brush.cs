using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chaos
{
    class point_brush
    {
        public Color color_ = Color.Black;
        public Point point_;
        public bool setting = false;
        public bool existence = false;


        public void take_new_position(Point choice_point)
        {
            point_.X = (point_.X + choice_point.X) / 2;   
            point_.Y = (point_.Y + choice_point.Y) / 2;
        }
    }
}
