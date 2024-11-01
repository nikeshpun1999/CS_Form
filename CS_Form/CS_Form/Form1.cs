namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int x = 0;
            int y = 0;
            for (int i = 0; i < 10; i++)
            {

                TestButton testButton = new TestButton((i % 3) * 100, (i / 3) * 100, 100, 100, i);
                Controls.Add(testButton);

            }
        }
    }
}
