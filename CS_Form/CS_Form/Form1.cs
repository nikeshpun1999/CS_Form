using System.Security.Cryptography.X509Certificates;

namespace CS_Form
{
    public partial class Form1 : Form
    {
        TestLabel _testLabel;
        TestButton _testButton;  
        public Form1()
        {
            InitializeComponent();
            int x = 0;
            int y = 0;
            for (int i = 0; i < 10; i++)
            {

                _testButton = new TestButton(this,(i % 3) * 100, (i / 3) * 100, 100, 100, i);
                Controls.Add(_testButton);

            }

            _testLabel = new TestLabel( "This is a label", 10, 400, 100, 500);
            Controls.Add(_testLabel);
          
        }
        public void LabelTextUpdate(string str)
        {
            _testLabel.UpdateText(str);
        }
    }
}
