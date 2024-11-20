using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Form
{
    internal class TestTextBox:TextBox
    {
        public TestTextBox(string str, int x, int y, int width, int height)
        {
            Text = str;
            Location = new Point(x, y);
            Size = new Size(width, height);
        }

        public void UpdateText(string str)
        {
            Text = str;
        }
    }
}
