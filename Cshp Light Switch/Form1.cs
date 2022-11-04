namespace Cshp_Light_Switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getIni();
        }

           private void getIni()
        {
            Settings get = new Settings();
            get.readIni();
            if (get.theme == "dark")
            {
                siticoneToggleSwitch1.Checked = true;
                this.BackColor = Color.FromArgb(32, 33, 36);
                this.ForeColor = Color.White;
            }
            else
            {
                siticoneToggleSwitch1.Checked = false;
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(32, 33, 36);
            }
        }
        

        private void siticoneToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            Settings set = new Settings();
            if (siticoneToggleSwitch1.Checked == true)
            {
                set.writeIni("SECTION", "key", "dark");
                this.BackColor = Color.FromArgb(32, 33, 36);
                this.ForeColor = Color.White;
                label1.Text = "Woof Woof!";
            }
            else
            {
                set.writeIni("SECTION", "key", "light");
                this.BackColor = Color.White;
                this.ForeColor = Color.FromArgb(32, 33, 36);
                label1.Text = "Dasar SIMP";
            }
        }
    }
}