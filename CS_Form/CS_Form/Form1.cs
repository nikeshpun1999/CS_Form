namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int x = 0;
            int y = 0;
            for (int i = 1; i <= 10; i++)
            {
                

                if (i>1 && i <= 4)
                {
                    x = (i*200) - 200;
                }
           
                if (i>4 && i <= 8)
                {
                    
                    y = 200;
                    x = (i * 200) - 1000;
                }

                if (i > 8 && i <= 10)
                {
                    y = 400;
                    x = (i * 200) - 1800;
                }
                TestButton testButton = new TestButton(x, y, 100, 40, "Clicked Button " + i, i);
                Controls.Add(testButton);

            }
        }
    }
}
