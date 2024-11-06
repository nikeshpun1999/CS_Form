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

            TestLabel testLabel = new TestLabel( "This is a label", 10, 400, 100, 500);
            Controls.Add(testLabel);

            //Label label = new Label();
            //label.Location = new Point(0, 400);
            //label.Text = "label";

            //Controls.Add(label);
        }
    }
}
