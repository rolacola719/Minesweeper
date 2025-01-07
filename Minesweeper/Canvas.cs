using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Canvas
    {
        //TODO Create properties for rows and columns to get the count from grid column and row definitions
        private int _rows;

        private int _columns;


        public int NumberOfMines { get; set; }

        private Grid _gameBoard;

        private Cell[] _cells;



        public Grid DrawBoard(int rows, int columns)
        {
            Grid GameBoard = new Grid();
            _gameBoard = GameBoard;
            _rows = rows;
            _columns = columns;

            GameBoard.BackgroundColor = Colors.Blue;
            GameBoard.MaximumWidthRequest = 500;
            GameBoard.MaximumHeightRequest = 500;

            for (int i = 0; i < _columns; i++)
            {
                GameBoard.ColumnDefinitions.Add(new ColumnDefinition { Width = 50 });
            }

            for (int i = 0; i < _rows; i++)
            {
                GameBoard.RowDefinitions.Add(new RowDefinition { Height = 50 });
            }

            return GameBoard;
        }

        public void DrawCells(Grid GameBoard)
        {
            //TODO Adjust button sizes to fit within constraints of the grid
            _cells = new Cell[_rows * _columns];
            int arrayIndex = 0;
            for (int i = 0; i < _columns; i++)
            {
                for (int j = 0; j < _rows; j++)
                {
                    Cell cell = new Cell();
                    GameBoard.Add(cell.button, j, i);

                    _cells[arrayIndex++] = cell;
                }
            }
        }
    }
}
