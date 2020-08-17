using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace chaos
{
    public partial class main_frame : Form
    {
        BackgroundWorker bw = new BackgroundWorker();
        Random rnd = new Random();
        figure_class[] figures = new figure_class[2];
        Point null_point;
        point_brush pbrush = new point_brush();
        bool isSetting = false;
        public bool proces = false;
        int state = 0;
        int figure_index = 0;
        public main_frame()
        {
            InitializeComponent();
            null_point.X = -1;
            null_point.Y = -1;
            for (int i = 0; i < figures.Length; ++i)
            {
                figures[i] = new figure_class();
                figures[i].number_of_vertices = 3;
                figures[i].update();
                for (int j = 0; j < 3; ++j) figures[i].position[j] = null_point;
            }
        }

        private void set_triangle_1_button_Click(object sender, EventArgs e)
        {
            if (!figures[0].complete)
            {
                figures[0].setting = true;
                set_triangle_1_button.Enabled = false;
                state = 1;
            }
        }


        private void check_state(in figure_class[] figures, out int index, out bool result)
        {
            result = false;
            index = -1;
            for (int i = 0; i < figures.Length; ++i)
            {
                if (figures[i].setting)
                {
                    result = true;
                    index = i;
                    break;
                }
            }
        }

        private void output_panel_MouseDown(object sender, MouseEventArgs e)
        {
            switch (state)
            {
                case 0:
                    break;
                case 1:
                    {
                        figure_index = -1;
                        isSetting = false;
                        check_state(figures, out figure_index, out isSetting);
                        if (isSetting && figure_index != -1)
                        {
                            figures[figure_index].position[figures[figure_index].complete_point] = e.Location;
                            ++figures[figure_index].complete_point;
                            paint_point(e.Location);
                            if (figures[figure_index].complete_point == figures[figure_index].number_of_vertices)
                            {
                                figures[figure_index].complete = true;
                                figures[figure_index].setting = false;
                                figure_index = -1;
                                isSetting = false;
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        main_script_background();
                        pbrush.point_ = e.Location;
                        pbrush.existence = true;
                        paint_point(e.Location);
                        state = 0;
                        break;
                    }
                default:
                    log("КАВО");
                    break;
            }

        }

        public void paint_point(Point p)
        {
            Pen pen_ = new Pen(Color.Black);
            output_panel.CreateGraphics().DrawEllipse(pen_, p.X, p.Y, 1, 1);
        }

        private void log(string str)
        {
            space_lable.Text = space_lable.Text + "\n" + str;
        }


        private void paint_button_Click(object sender, EventArgs e)
        {
            paint(figures[0]);
        }


        private void paint(figure_class fig)
        {
            Pen pen_ = new Pen(Color.Black);
            for (int i = 1; i < fig.position.Length; ++i)
            {
                output_panel.CreateGraphics().DrawLine(pen_, fig.position[i - 1], fig.position[i]);
            }
            output_panel.CreateGraphics().DrawLine(pen_, fig.position[0], fig.position[fig.position.Length - 1]);

        }

        private void paly_button_Click(object sender, EventArgs e)
        {
            proces = !proces;
        }


        private void start_poin_button_Click(object sender, EventArgs e)
        {
            start_poin_button.Enabled = false;
            state = 2;
            Console.WriteLine("test1");
        }


        async private void main_script_background()
        {
            Pen pen_ = new Pen(Color.Black);
            int ran = rnd.Next(3);
            await Task.Run(() =>
            {
                while (true)
                {
                    while (proces)
                    {
                        pbrush.take_new_position(figures[0].position[ran]);
                        paint_point(pbrush.point_);
                        ran = rnd.Next(3);
                    }
                }

            });
        }
    }
}

