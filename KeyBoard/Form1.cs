namespace KeyBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LCtrl_Click(object sender, EventArgs e)
        {

        }

        private void RCtrl_Click(object sender, EventArgs e)
        {

        }

        private void LWin_Click(object sender, EventArgs e)
        {

        }

        private void RWin_Click(object sender, EventArgs e)
        {

        }

        private void LAlt_Click(object sender, EventArgs e)
        {

        }

        private void RAlt_Click(object sender, EventArgs e)
        {

        }

        private void LShift_Click(object sender, EventArgs e)
        {

        }

        private void RShift_Click(object sender, EventArgs e)
        {

        }

        private void CapsLock_Click(object sender, EventArgs e)
        {

        }

        private void Tab_Click(object sender, EventArgs e)
        {

        }

        private void DIFFICULTY_trackBar_Scroll(object sender, EventArgs e)
        {
            DIFFICULTY_lvl.Text = Convert.ToString(DIFFICULTY_trackBar.Value);
        }

        private void ENTER_TEXT_TextChanged(object sender, EventArgs e)
        {
            //DIFFICULTY_lvl.Text = ENTER_TEXT.Text;
        }
    }
}