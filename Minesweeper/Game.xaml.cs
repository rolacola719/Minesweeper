namespace Minesweeper;

public partial class Game : ContentPage
{
    public Game()
    {
        InitializeComponent();
    }
    
    public Game(int Columns, int Rows, int NumberOfBombs)
    {
        Canvas canvas = new Canvas();
        Grid GameBoard = canvas.DrawBoard(Rows, Columns);

        canvas.DrawCells(GameBoard);

        Content = GameBoard;
    }
}