using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Form
{
    internal class TestButton : Button
    {
        public TestButton(int x, int y, int width, int height) {
            Click += OnClick;
            Text = "Click Me!!!";
            Location = new Point(x, y);
            Size = new Size(width,height);
        }
        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("Clicked");
        }
    }
}
