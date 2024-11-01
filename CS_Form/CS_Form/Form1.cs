namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TestButton testButton = new TestButton(0,0,100,40);
            Controls.Add(testButton);

            TestButton testButton2 = new TestButton(100,100,100,40);
            Controls.Add(testButton2);
        }
    }
}
