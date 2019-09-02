using System;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeper
{
    class MineSweeper
    {
        /// <summary>
        /// Кол-во ячеек по ширине и высоте.
        /// </summary>
        Point Count;
        /// <summary>
        /// Отступ сверху.
        /// </summary>
        Point Offset;
        /// <summary>
        /// Панель, на которой рисуется игра.
        /// </summary>
        Panel MsPanel;
        /// <summary>
        /// Размер ячейки.
        /// </summary>
        Size SizeCell;
        /// <summary>
        /// Отступы в прорисовки ячеек по ширине и высоте.
        /// </summary>
        Size CellOfset;
        /// <summary>
        /// Массив ячеек.
        /// </summary>
        Cell[,] CellsArray;
        /// <summary>
        /// Экземпляр Graphics, на нем рисуется игра.
        /// </summary>
        Graphics graphics;
        /// <summary>
        /// Выбранная ячейка.
        /// </summary>
        Cell SelectedCell;
        /// <summary>
        /// Кол-во бомб в игре.
        /// </summary>
        ushort CountBombs;
        /// <summary>
        /// Первое нажатие.
        /// </summary>
        public bool FirstClick = true;

        private ushort Flags = 0;
        private ToolStripTextBox TextBoxGame;

        Random random = new Random();
        /// <summary>
        /// Создание экземпляра игры с указанными параметрами.
        /// </summary>
        /// <param name="count">Кол-во строк (X) и столбцов (Y) игры.</param>
        /// <param name="panel">Панель, на которой будет рисоваться игра.</param>
        /// <param name="sizeCell">Размеры ячейки.</param>
        /// <param name="offset">Отступ от верхней грани.</param>
        /// <param name="cellOfset">Отступ по высоте и ширине самого места, на котром потом рисуется ячейка.</param>
        public MineSweeper(Point count, Panel panel, Size sizeCell, Point offset, Size cellOfset, ushort countBombs, ToolStripTextBox textBox)
        {
            Count = count;
            MsPanel = panel;
            SizeCell = sizeCell;
            graphics = panel.CreateGraphics();
            Offset = offset;
            CellOfset = cellOfset;
            CountBombs = countBombs;
            TextBoxGame = textBox;
        }
        /// <summary>
        /// Создание экземпляра игры с указанными параметрами.
        /// </summary>
        /// <param name="count">Кол-во строк (X) и столбцов (Y) игры.</param>
        /// <param name="panel">Панель, на которой будет рисоваться игра.</param>
        /// <param name="sizeCell">Размеры ячейки.</param>
        /// <param name="offset">Отступ от верхней грани.</param>
        /// <param name="cellOfset">Отступ по высоте и ширине самого места, на котром потом рисуется ячейка.</param>
        public void setParams(Point count, Panel panel, Size sizeCell, Point offset, Size cellOfset, ushort countBombs, ToolStripTextBox textBox)
        {
            Count = count;
            MsPanel = panel;
            SizeCell = sizeCell;
            graphics = panel.CreateGraphics();
            Offset = offset;
            CellOfset = cellOfset;
            CountBombs = countBombs;
            TextBoxGame = textBox;
        }
        /// <summary>
        /// Заполнение массива ячеек.
        /// </summary>
        private void UpdateCells()
        {
            CellsArray = new Cell[Count.X, Count.Y];
            for (byte i = 0; i < Count.X; i++)
                for (byte j = 0; j < Count.Y; j++)
                    CellsArray[i, j] = new Cell(SizeCell, 0, Color.Gray, new Pen(Brushes.Black, 1), new Point(i, j));
        }
        /// <summary>
        /// Вырисовывание ячеек.
        /// </summary>
        public void Draw()
        {
            for (byte i = 0; i < Count.X; i++)
                for (byte j = 0; j < Count.Y; j++)
                    CellsArray[i, j].Draw(new Point(i * (SizeCell.Width + CellOfset.Width) + Offset.X, j * (SizeCell.Height + CellOfset.Height) + Offset.Y), graphics);
        }
        /// <summary>
        /// Метод, считывающие движение мыши.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MouseMoving(object sender, MouseEventArgs e)
        {
            if (FindCell(e.Location) == null || SelectedCell == FindCell(e.Location)) return;

            if (SelectedCell != null)
            {
                SelectedCell.ChangeColorAtStatus(Cell.Status.Default);
                SelectedCell.ReDraw(graphics);
            }
            (SelectedCell = FindCell(e.Location)).ChangeColorAtStatus(Cell.Status.Selected);
            SelectedCell.ReDraw(graphics);
        }
        /// <summary>
        /// Поиск ячейки по точке вхождения.
        /// </summary>
        /// <param name="point">Точка</param>
        /// <returns></returns>
        private Cell FindCell(Point point)
        {
            try
            {
                for (byte i = 0; i < Count.X; i++)
                    for (byte j = 0; j < Count.Y; j++)
                        if (CellsArray[i, j].CheckPointerEnter(point))
                            return CellsArray[i, j];
            }
            catch { }
            return null;
        }
        private void InsertBombs(ushort count)
        {
            Cell temp;
            while (count > 0)
            {
                Point PointTemp = new Point(random.Next(Count.X), random.Next(Count.Y));
                if ((temp = CellsArray[PointTemp.X, PointTemp.Y]).Index == 9) continue;
                temp.Index = 9;
                UpIndexCells(PointTemp);
                count--;
            }
        }

        private void InsertBombs(ushort count, Cell pointClick)
        {
            Cell temp;
            while (count > 0)
            {
                Point PointTemp = new Point(random.Next(Count.X), random.Next(Count.Y));
                if ((temp = CellsArray[PointTemp.X, PointTemp.Y]).Index == 9 || (temp.ID.X >= pointClick.ID.X - 1 
                    && temp.ID.X <= pointClick.ID.X + 1) || (temp.ID.Y >= pointClick.ID.Y - 1 && temp.ID.Y <= pointClick.ID.Y + 1)) continue;
                temp.Index = 9;
                UpIndexCells(PointTemp);
                count--;
            }
        }

        private void UpIndexCells(Point point)
        {
            for (byte i = (byte)((point.X - 1) < 0 ? 0 : (point.X - 1)); i < Count.X && i <= point.X + 1; i++)
                for (byte j = (byte)((point.Y - 1) < 0 ? 0 : (point.Y - 1)); j < Count.Y && j <= point.Y + 1; j++)
                    if (CellsArray[i, j] != null && CellsArray[i, j].Index != 9) CellsArray[i, j].Index = (byte)((int)CellsArray[i, j].Index + 1);
        }

        public void MouseClick(object sender, MouseEventArgs e)
        {
            Cell temp;
            if ((temp = FindCell(e.Location)) == null) return;
            if (e.Button.Equals(MouseButtons.Left))
            {
                if (FirstClick)
                {
                    FirstStart(temp);
                    FirstClick = false;
                }
                if (temp.Index == 0)
                {
                    OpenZeros(temp.ID);
                    Draw();
                }
                else if (temp.Index != 0 && temp.Index != 9)
                {
                    temp.Show();
                    temp.ReDraw(graphics);
                }
                else if (!temp.Flagged)
                {
                    temp.Explose(graphics);
                    GameOver();
                }
            }
            else if (e.Button.Equals(MouseButtons.Right))
            {
                temp.SetFlag();
                temp.ReDraw(graphics);
                Flags += (ushort)(temp.Flagged ? 1 : -1);
            }
            SetInforms(TextBoxGame);
            if (CountBombs == Flags) CheckWin(); 
        }

        private void CheckWin()
        {
            if (CheckWinCells()) MessageBox.Show("Вы победили!!!");

        }
        
        private bool CheckWinCells()
        {
            try
            {
                for (byte i = 0; i < Count.X; i++)
                    for (byte j = 0; j < Count.Y; j++)
                        if (CellsArray[i, j].CellColor == Cell.Colors[(byte)Cell.Status.Hiden] && !CellsArray[i, j].Flagged)
                            return false;
                return true;
            }
            catch { }
            return false;
        }

        private void SetInforms(ToolStripTextBox tb)
        {
            tb.Text = String.Format("Бомб: {0}; Флажков: {1}", CountBombs, Flags);
        }

        public void Start()
        {
            UpdateCells();
            InsertBombs(CountBombs);
            Draw();
        }

        public void CreateMap()
        {
            FirstClick = true;
            UpdateCells();
            Draw();
        }

        public void FirstStart(Cell cell)
        {
            InsertBombs(CountBombs, cell);
            Draw();
        }
        private void OpenZeros(Point point)
        {
            for (byte i = (byte)((point.X - 1) < 0 ? 0 : (point.X - 1)); i < Count.X && i <= point.X + 1; i++)
                for (byte j = (byte)((point.Y - 1) < 0 ? 0 : (point.Y - 1)); j < Count.Y && j <= point.Y + 1; j++)
                    if (!CellsArray[i, j].Visible)
                    {
                        CellsArray[i, j].Show();
                        if (CellsArray[i, j].Index == 0) OpenZeros(new Point(i, j));
                    }
        }

        public Size GetSizeOfGame(Size OffsetSize)
        {
            return new Size(Count.X * (SizeCell.Width + CellOfset.Width) + Offset.X + OffsetSize.Width, 
                Count.Y * (SizeCell.Height + CellOfset.Height) + Offset.Y + OffsetSize.Height);
        }

        public void reSize(object sender, EventArgs e)
        {
            this.graphics = MsPanel.CreateGraphics();
            try
            {
                Draw();
            }
            catch { }
        }

        private void GameOver()
        {
            ShowBoms();
            MessageBox.Show(String.Format("Вы проиграли. Всего бомб в игре: {0}, поставлено флажков: {1}", CountBombs, Flags));
        }

        private void ShowBoms()
        {
                for (byte i = 0; i < Count.X; i++)
                    for (byte j = 0; j < Count.Y; j++)
                        if (CellsArray[i, j].Index == 9 && !CellsArray[i, j].Explosed)
                            CellsArray[i, j].Explose(graphics);
        }
    }
}
