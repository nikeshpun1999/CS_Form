namespace CS_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TestButton testButton = new TestButton(0,0,100,40,"Clicked Button 1", 1);
            Controls.Add(testButton);

            TestButton testButton2 = new TestButton(200,0,100,40, "Clicked Button 2",2);
            Controls.Add(testButton2);

            TestButton testButton3 = new TestButton(400, 0, 100, 40, "Clicked Button 3",3);
            Controls.Add(testButton3);

            TestButton testButton4 = new TestButton(600, 0, 100, 40, "Clicked Button 4",4);
            Controls.Add(testButton4);

            TestButton testButton5 = new TestButton(0, 200, 100, 40, "Clicked Button 5",5);
            Controls.Add(testButton5);

            TestButton testButton6 = new TestButton(200, 200, 100, 40, "Clicked Button 6",6);
            Controls.Add(testButton6);

            TestButton testButton7 = new TestButton(400, 200, 100, 40, "Clicked Button 7",7);
            Controls.Add(testButton7);

            TestButton testButton8 = new TestButton(600, 200, 100, 40, "Clicked Button 8",8);
            Controls.Add(testButton8);

            TestButton testButton9 = new TestButton(0, 400, 100, 40, "Clicked Button 9",9);
            Controls.Add(testButton9);

            TestButton testButton10 = new TestButton(200, 400, 100, 40, "Clicked Button 10",10);
            Controls.Add(testButton10);
        }
    }
}
