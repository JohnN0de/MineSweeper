using System.Windows.Forms;

namespace MineSweeper
{
    public partial class FormOptions : Form
    {
        public FormOptions(Form1 form)
        {
            InitializeComponent();
            button1.Click += form.SubmitOptions;
        }
    }
}
