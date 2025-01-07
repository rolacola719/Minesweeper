namespace Minesweeper
{
    public partial class MainPage : ContentPage
    {

        private int _columns;
        private int _rows;
        private int _bombs;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ColumnsSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            _columns = (int)e.NewValue;
            ColumnsEntry.Text = _columns.ToString();
            BombsSlider.Maximum = 0.3 * (_rows * _columns);
        }

        private void ColumnsEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ColumnsEntry.Text != "")
            {
                _columns = Convert.ToInt32(e.NewTextValue);
                ColumnsSlider.Value = _columns;
                BombsSlider.Maximum = 0.3 * (_rows * _columns);
            }
        }

        private void RowsSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            _rows = (int)e.NewValue;
            RowsEntry.Text = _rows.ToString();
            BombsSlider.Maximum = 0.3 * (_rows * _columns);
        }

        private void RowsEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (RowsEntry.Text != "")
            {
                _rows = Convert.ToInt32(e.NewTextValue);
                RowsSlider.Value = _rows;
                BombsSlider.Maximum = 0.3 * ( _rows * _columns);
            }
        }

        private void BombsSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            _bombs = (int)e.NewValue;
            BombsEntry.Text = _bombs.ToString();

        }

        private void BombsEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (BombsEntry.Text != "")
            {
                _bombs = Convert.ToInt32(e.NewTextValue);
                BombsSlider.Value = _bombs;
            }
        }

        private async void PlayButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Game(_columns, _rows, _bombs));
        }
    }

}
