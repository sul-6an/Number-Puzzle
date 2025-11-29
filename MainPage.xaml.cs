namespace slyde
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            int row = Grid.GetRow(btn);
            int col = Grid.GetColumn(btn);
            int emptyRow = Grid.GetRow(btn0);
            int emptyCol = Grid.GetColumn(btn0);

            if (row == emptyRow && (emptyCol == col + 1 || emptyCol == col - 1))
            {
                Grid.SetRow(btn, emptyRow);
                Grid.SetColumn(btn, emptyCol);
                Grid.SetRow(btn0, row);
                Grid.SetColumn(btn0, col);

            }
            if (col == emptyCol && (emptyRow == row + 1 || emptyRow == row - 1))
            {

                Grid.SetRow(btn, emptyRow);
                Grid.SetColumn(btn, emptyCol);
                Grid.SetRow(btn0, row);
                Grid.SetColumn(btn0, col);
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            btn0.IsEnabled = true;
            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn3.IsEnabled = true;
            btn4.IsEnabled = true;
            btn5.IsEnabled = true;
            btn6.IsEnabled = true;
            btn7.IsEnabled = true;
            btn8.IsEnabled = true;
            shuffle();

        }
        private void shuffle()
        {
            string[] numbers = { "1", "2", "3", "4", "5", "6", "7", "8" };

            Random.Shared.Shuffle(numbers);

            btn1.Text = numbers[0];
            btn2.Text = numbers[1];
            btn3.Text = numbers[2];
            btn4.Text = numbers[3];
            btn5.Text = numbers[4];
            btn6.Text = numbers[5];
            btn7.Text = numbers[6];
            btn8.Text = numbers[7];
        }
    }
}
