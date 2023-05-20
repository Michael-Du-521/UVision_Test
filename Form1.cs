namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // specify the data source
            int[] scores = { 50, 60, 75, 95 };
            //Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;
            //Execute the query.
            foreach (int i in scoreQuery)
                {
                 Console.WriteLine(i + " ");
Console.WriteLine("Today I use Ubuntu to commit a change")
            }


        }
    }
}