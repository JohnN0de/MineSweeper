using System.Drawing;

namespace MineSweeper
{
    /// <summary>
    /// Класс графических объектов.
    /// </summary>
    class GraphicObjs
    {
        /// <summary>
        /// Вывод флажка на данную позицию.
        /// </summary>
        /// <param name="Pos">Позиция</param>
        /// <param name="CellSize">Размеры ячейки</param>
        /// <param name="graphics">Экземпляр Graphics</param>
        public static void DrawFlag(Point Pos, Size CellSize, Graphics graphics, byte offsetX = 1, byte offsetY = 1)
        {
            Point[] Flag = new Point[3] { new Point(Pos.X + offsetX, Pos.Y + offsetY), new Point(Pos.X + CellSize.Width - offsetX, Pos.Y + CellSize.Height / 4), new Point(Pos.X + offsetX, Pos.Y + CellSize.Height / 2 )};
            Point[] Line = new Point[2] { new Point(Pos.X + offsetX, Pos.Y + offsetY), new Point(Pos.X + offsetX, Pos.Y + CellSize.Height - offsetY) };
            graphics.FillPolygon(new SolidBrush(Color.Orange), Flag);
            graphics.DrawPolygon(new Pen(Color.Black, 1), Flag);
            graphics.DrawLine(new Pen(Color.Black, 1), Line[0], Line[1]);
        }

        public static void DrawBomb(Point Pos, Size CellSize, Graphics graphics, byte offsetX = 1, byte offsetY = 1)
        {
            graphics.FillEllipse(new SolidBrush(Color.DarkRed), new Rectangle(new Point(Pos.X + offsetX / 2, Pos.Y + offsetY / 2), new Size(CellSize.Width - offsetX, CellSize.Height - offsetY)));
            graphics.DrawEllipse(new Pen(Color.Black, 1), new Rectangle(new Point(Pos.X + offsetX / 2, Pos.Y + offsetY / 2), new Size(CellSize.Width - offsetX, CellSize.Height - offsetY)));
        }
    }
}
