namespace Maday
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        int incrementador = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (incrementador == 1)
            {
                count++;
                incrementador++;
            }
            else
            {
                count = count * incrementador;
                incrementador++;
            }

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
