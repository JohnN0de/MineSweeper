using System;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        MineSweeper mineSweeper;
        static Size CellSize = new Size(8, 8);
        FormOptions formOptions;

        public Form1()
        {
            InitializeComponent();
            formOptions = new FormOptions(this);
            //InitializeGame(formOptions);
        }

        private void начатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGame(formOptions);
            this.Size = mineSweeper.GetSizeOfGame(new Size(20, 40));
            mineSweeper.reSize(null, null);
            mineSweeper.CreateMap();
        }

        private void InitializeGame()
        {

            mineSweeper = new MineSweeper(new Point(128, 64), panel1, CellSize, new Point(0 + 1, menuStrip1.Height + 1), new Size(2, 2), 1024, toolStripTextBox1);
            panel1.MouseMove += mineSweeper.MouseMoving;
            panel1.MouseClick += mineSweeper.MouseClick;
            this.ResizeEnd += mineSweeper.reSize;
        }

        private void InitializeGame(FormOptions formOp)
        {

            mineSweeper = new MineSweeper(new Point((ushort)formOp.numericUpDownSizeGameX.Value, (ushort)formOp.numericUpDownSizeGameY.Value), panel1, new Size((ushort)formOp.numericUpDown3CellSizeX.Value, (ushort)formOp.numericUpDownCellSizeY.Value), new Point(1, menuStrip1.Height + 1), new Size((ushort)formOp.numericUpDownOffsetCellX.Value, (ushort)formOp.numericUpDownOffsetCellY.Value), (ushort)formOp.numericUpDownCountBombs.Value, toolStripTextBox1);
            panel1.MouseMove += mineSweeper.MouseMoving;
            panel1.MouseClick += mineSweeper.MouseClick;
            this.ResizeEnd += mineSweeper.reSize;
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOptions.Show();
        }

        public void SubmitOptions(object sender, EventArgs e)
        {
            formOptions.Hide();
            //InitializeGame(formOptions);
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игра начнется когда ты откроешь первую ячейку. Многие питаются вначале открыть сразу несколько клеток, клацая случайно по минному полю. Если открылось несколько ячеек, тогда уже можно оценить ситуацию.\nЧисла в Сапере — это наши подсказки, они нам говорят сколько и где расположено мин.Например, ячейка с число 1 говорит нам что вокруг нее, вверху, внизу, слева, справа и по диагонали, находится только 1 мина.Ячейка с числом 2 говорит нам что вокруг нее две мины, число 3 означает что вокруг клетки 3 мины и так далее.\nСмотрите на все открывшиеся нам числа и определяем, где могут располагаться мины.Если двойка значит вокруг две мины, тройка значит три мины и так далее, пока не пометим все мины и не откроем все свободные клетки.");
        }

        private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Данную игру написал студент группы И-4-16 Исмоилов Ш. А.");
        }
    }
}
