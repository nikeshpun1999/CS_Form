using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Form
{
    internal class TestButton : Button
    {
        string globalmessage;

        public TestButton(int x, int y, int width, int height,int button_num) {
            Console.WriteLine(button_num);
            globalmessage = ""+button_num;
            Click += OnClick;
            Text = ""+button_num;
            Location = new Point(x, y);
            Size = new Size(width,height);
        }
        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show(globalmessage);
        }
    }
}
