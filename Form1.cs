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
            this.Hide();//�������� ����� �����������            
            form2.ShowDialog();//���������� ����� ������
            this.Close();//��� �������� ����� ���� ��������� � ����� �����������

        }
    }
}