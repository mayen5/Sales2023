namespace Sales.Mobile
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterIncrement(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterLbl.Text = $"Clicked {count} time";
            else
                CounterLbl.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(IncrementBtn.Text);
        }

        private void OnCounterDecrement(object sender, EventArgs e)
        {
            count--;

            if (count == 1)
                CounterLbl.Text = $"Clicked {count} time";
            else
                CounterLbl.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(DecrementBtn.Text);
        }

        private void OnCounterReset(object sender, EventArgs e)
        {
            count = 0;

            CounterLbl.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(ResetBtn.Text);
        }
    }
}