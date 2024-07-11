using ColorToHexToolApp;

namespace ColorToHexToolApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            ColorToHexConverter color = new ColorToHexConverter();
            string output = color.ColorNameToHex(txtColorName.Text);
            txtHexCode.Text = output;
        }
    }
}
