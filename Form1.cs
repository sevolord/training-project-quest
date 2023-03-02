namespace Quest
{
    public partial class Autorize : Form
    {
        public Autorize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string heroName = textBox1.Text;
            int heroClass = comboBox1.SelectedIndex;
            Game form2 = new Game(heroClass,heroName);
            this.Hide();//скрываем форму авторизации            
            form2.ShowDialog();//показываем форму сигрой
            this.Close();//при закрытии формы игры закрываем и форму авторизации

        }
    }
}