namespace Laba2_task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtInputString.Text = Properties.Settings.Default.sentence.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence;
            try
            {
              sentence = this.txtInputString.Text;
            }
            catch
            {
                return;
            }
            Properties.Settings.Default.sentence = sentence;
            Properties.Settings.Default.Save();
            MessageBox.Show(Logic.GetStringsReverse(sentence));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    public class Logic
    {
        public static string GetStringsReverse(string sentence)
        {
            string reversed = "";
            var words = sentence.Split(' ');
            foreach (var word in words)
            {
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversed += word[i];
                }

                reversed += " ";
            }

            return reversed.Trim();
        }
    }
}