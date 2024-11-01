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
        int button_number;
        public TestButton(int x, int y, int width, int height, string message,int button_num) {
            globalmessage = message;
            Click += OnClick;
            Text = "Button " + button_num;
            Location = new Point(x, y);
            Size = new Size(width,height);
        }
        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show(globalmessage);
        }
    }
}
