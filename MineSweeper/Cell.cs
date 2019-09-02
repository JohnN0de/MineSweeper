using System.Drawing;

namespace MineSweeper
{
    /// <summary>
    /// Класс формальной ячейки
    /// </summary>
    class Cell
    {
        /// <summary>
        /// Размер ячейки по ширине и высоте.
        /// </summary>
        Size CellSize;
        /// <summary>
        /// Индекс ячейки, необходим для отслеживания состояния ячейки.
        /// </summary>
        public byte Index = 0;
        /// <summary>
        /// Открытость ячейки.
        /// </summary>
        public bool Visible = false;
        /// <summary>
        /// Цвет ячейки.
        /// </summary>
        public Color CellColor = Color.Gray;
        /// <summary>
        /// Экземпляр класса Pen ячейки.
        /// </summary>
        public Pen CellPen;
        /// <summary>
        /// Текущая позиция ячейки.
        /// </summary>
        public Point Position;
        /// <summary>
        /// Перечисление всех статусов ячейки.
        /// </summary>
        public enum Status {Hiden, Selected, Showed, Exsplosed, Default}
        /// <summary>
        /// Массив возможных цветов ячейки в зависимости от статуса.
        /// </summary>
        public static Color[] Colors = new Color[4] { Color.Gray, Color.AliceBlue, Color.White, Color.Red };
        /// <summary>
        /// Стандартный цвет ячейки.
        /// </summary>
        private Color Default;
        /// <summary>
        /// Идентификатор ячейки в общем массиве ячеек.
        /// </summary>
        public Point ID;
        /// <summary>
        /// Состояние поставленности флажка на ячейку.
        /// </summary>
        public bool Flagged = false;

        public bool Explosed = false;
        /// <summary>
        /// Установка параметров.
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="heigth">Высота</param>
        /// <param name="ind">Индекс ячейки</param>
        public Cell(Size size, byte ind, Color color, Pen pen, Point id)
        {
            CellSize = size;
            this.Index = ind;
            CellColor = color;
            CellPen = pen;
            Default = Colors[(byte)Status.Hiden];
            ID = id;
        }
        /// <summary>
        /// Вывод ячееки.
        /// </summary>
        /// <param name="point">Местоположение ячейки</param>
        /// <param name="graphics">Экземпляр Graphics, на котором необходимо вывести ячейку.</param>
        public void Draw(Point point, Graphics graphics)
        {
            Position = point;
            graphics.FillPolygon(new SolidBrush(CellColor), new Point[4] { point, new Point(point.X + CellSize.Width, point.Y), new Point(point.X + CellSize.Width, point.Y + CellSize.Height), new Point(point.X, point.Y + CellSize.Height) });
            graphics.DrawPolygon(CellPen, new Point[4] { point, new Point(point.X + CellSize.Width, point.Y), new Point(point.X + CellSize.Width, point.Y + CellSize.Height), new Point(point.X, point.Y + CellSize.Height) });
            if (Visible && Index != 0 && Index != 9) graphics.DrawString(Index.ToString(), new Font("Times New Romans", CellSize.Width / 2), Brushes.Black, new Point(point.X + CellSize.Width / 4, point.Y + CellSize.Height / 4));
            if (!Visible && Flagged) GraphicObjs.DrawFlag(Position, CellSize, graphics, 5, 2);
            if (Explosed) GraphicObjs.DrawBomb(Position, CellSize, graphics, 10, 10);
        }
        /// <summary>
        /// Проверяет вхождение данной точки.
        /// </summary>
        /// <param name="point">Точка</param>
        /// <returns></returns>
        public bool CheckPointerEnter(Point point)
        {
            return point.X > Position.X && point.X < Position.X + CellSize.Width && point.Y > Position.Y && point.Y < Position.Y + CellSize.Height;
        }
        /// <summary>
        /// Изменяет цвет данной ячейки в зависимости от указанного состояния
        /// </summary>
        /// <param name="status">Состояние, влиет на цвет ячейки.</param>
        public void ChangeColorAtStatus(Status status)
        {
            if (status != Status.Default)
                CellColor = Colors[(byte)status];
            else CellColor = Default;
        }
        /// <summary>
        /// Перерисовка ячейки в том же месте.
        /// </summary>
        /// <param name="graphics">Экземпляр класса Graphics</param>
        public void ReDraw(Graphics graphics)
        {
            Draw(Position, graphics);
        }

        public void Show()
        {
            Visible = true;
            Default = CellColor = Colors[(byte)Status.Showed];
        }

        public void SetFlag()
        {
            Flagged = !Flagged;
        }

        public void Explose(Graphics graphics)
        {
            Explosed = Visible = true;
            Default = Colors[(byte)Status.Exsplosed];
            ChangeColorAtStatus(Status.Exsplosed);
            ReDraw(graphics);
        }
    }
}
