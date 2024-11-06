using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Form
{
     class TestButton : Button
    {
        Form1 _form1;

        string globalmessage;

        public TestButton(Form1 form1,int x, int y, int width, int height,int button_num) {

            _form1 = form1;

            globalmessage = ""+button_num;
            Click += OnClick;
            Text = ""+button_num;
            Location = new Point(x, y);
            Size = new Size(width,height);
        }
        public void OnClick(object sender, EventArgs s)
        {
            _form1.LabelTextUpdate(globalmessage);  
        }
    }
}
