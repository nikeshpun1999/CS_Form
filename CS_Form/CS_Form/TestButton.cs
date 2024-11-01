using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Form
{
    internal class TestButton : Button
    {
        public TestButton(int x, int y) {
            Click += OnClick;
            Text = "Click Me!!!";
            Location = new Point(x, y);
        }
        public void OnClick(object sender, EventArgs s)
        {
            MessageBox.Show("Clicked");
        }
    }
}
