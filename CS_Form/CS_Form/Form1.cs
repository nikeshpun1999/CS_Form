using System;
using System.Security.Cryptography.X509Certificates;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;
        TestButton _testButton;
        TestTextBox _testTextBox;

        string[] strings = {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "Textbox"
            };
        public Form1()
        {
            
            InitializeComponent();
            int x = 0;
            int y = 0;
            for (int i = 0; i < 10; i++)
            {

                _testButton = new TestButton(this,(i % 3) * 100, (i / 3) * 100, 100, 100, i,strings[i]);
                Controls.Add(_testButton);

            }

            _testLabel = new TestLabel( "This is a label", 500, 10, 500, 50);
            Controls.Add(_testLabel);


            _testTextBox = new TestTextBox(strings[10], 500, 110, 500, 50);
            Controls.Add(_testTextBox);

        }
        public void LabelTextUpdate(string str)
        {
            _testLabel.UpdateText(str);
        }

        public void LabelTextboxUpdate(int index)
        {
            
            string tmp = strings[index];
            strings[index] = strings[10];
            strings[10] = tmp;

            for (int j = 0; j <= 10; j++)
            {
                Controls.RemoveAt(0);
            }

            Controls.Remove(_testTextBox);
;
            _testTextBox.UpdateText(strings[10]);
            //MessageBox.Show(strings[0] + strings[1] + strings[2] + strings[3] + strings[4] + strings[5] + strings[6] + strings[7] + strings[8] + strings[9] + strings[10]);

            for (int i = 0; i < 10; i++)
            {
               
                _testButton = new TestButton(this, (i % 3) * 100, (i / 3) * 100, 100, 100, i, strings[i]);
                Controls.Add(_testButton);

            }

            _testLabel = new TestLabel("This is a label", 500, 10, 500, 50);
            Controls.Add(_testLabel);


            _testTextBox = new TestTextBox(strings[10], 500, 110, 500, 50);
            Controls.Add(_testTextBox);
        }

    }
}
