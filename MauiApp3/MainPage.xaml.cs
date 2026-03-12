namespace MauiApp3
{
    public partial class MainPage : ContentPage
    {
        private bool isXTurn = true; // Track whose turn it is
        public MainPage()
        {
            InitializeComponent();
        }

        private void Cell_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == null)   // prevent overwriting
            {
                if (isXTurn)
                {
                    btn.Text = "X";
                    btn.TextColor = Colors.White;         // X color
                    btn.BackgroundColor = Color.FromArgb("#2C3E50"); // X background
                }
                else
                {
                    btn.Text = "O";
                    btn.TextColor = Colors.Black;         // O color
                    btn.BackgroundColor = Color.FromArgb("#F39C12"); // O background
                }

                isXTurn = !isXTurn; // Switch turns

                string who = WhoWon();
                if (who != "")
                {
                    DisplayAlert("Game Over", $"{who} wins!", "OK");
                }

            }
        }

        private void ResetBoard()
        {
            Button11.Text = null;
            Button12.Text = null;
            Button13.Text = null;
            Button21.Text = null;
            Button22.Text = null;
            Button23.Text = null;
            Button31.Text = null;
            Button32.Text = null;
            Button33.Text = null;
        }

        public string WhoWon()
        {
            if (Button11.Text == Button12.Text && Button12.Text == Button13.Text && Button11.Text != null)
                return Button11.Text;

            if (Button21.Text == Button22.Text && Button22.Text == Button23.Text && Button21.Text != null)
                return Button21.Text;

            if (Button31.Text == Button32.Text && Button32.Text == Button33.Text && Button31.Text != null)
                return Button31.Text;

            if (Button11.Text == Button21.Text && Button21.Text == Button31.Text && Button11.Text != null)
                return Button11.Text;

            if (Button12.Text == Button22.Text && Button22.Text == Button32.Text && Button12.Text != null)
                return Button12.Text;

            if (Button13.Text == Button23.Text && Button23.Text == Button33.Text && Button13.Text != null)
                return Button13.Text;

            if (Button11.Text == Button22.Text && Button22.Text == Button33.Text && Button11.Text != null)
                return Button11.Text;

            return "";
        }
    }
}
