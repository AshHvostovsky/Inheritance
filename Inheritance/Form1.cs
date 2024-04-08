namespace Inheritance
{
    public partial class Form1 : Form
    {
        List<CosmicObject> objectsList = new List<CosmicObject>();
        public Form1()
        {
            InitializeComponent();

            ShowInfo();
        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.objectsList.Clear();
            var rnd = new Random();

            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // ��������� ��������� ����� �� 0 �� 2 (�� ������� �� ������� �� 3)
                {
                    case 0: // ���� 0, �� �������
                        this.objectsList.Add(Planet.Generate());
                        break;
                    case 1: // ���� 1 �� ������
                        this.objectsList.Add(Star.Generate());
                        break;
                    case 2: // ���� 2 �� ������
                        this.objectsList.Add(Comet.Generate());
                        break;
                        // ��������� ������ ����� ������������
                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            // ������� �������� ��� ������ ���
            int planetsCount = 0;
            int starsCount = 0;
            int cometsCount = 0;

            // ��������� �� ����� ������
            foreach (var myObject in this.objectsList)
            {
                if (myObject is Planet)
                {
                    planetsCount += 1;
                }
                else if (myObject is Star)
                {
                    starsCount += 1;
                }
                else if (myObject is Comet)
                {
                    cometsCount += 1;
                }
            }

            // � �� � ������� ��� ��� ���� �� �����
            txtInfo.Text = "����\t����\t����"; // ����� ������, ����� ������ �� �����
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", planetsCount, starsCount, cometsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // ���� ������ ����, �� ������� ��� ����� � ������ �� �������
            if (this.objectsList.Count == 0)
            {
                txtOut.Text = "����� Q_Q";
                return;
            }

            // ����� ������ ������
            var myObject = this.objectsList[0];
            // ��� ��� �� ����������, ������ ��� �� ����� ���� �������� ��������� �� ������� � ������
            // ��� �������� ��������� ������, ��� ��� ���� ������ �������, ����� ��� ���
            this.objectsList.RemoveAt(0);

            // �� � ������ ��������� ���������� ��� ������

            /*
            if (myObject is Planet)
            {
                txtOut.Text = "�������";
            }
            else if (myObject is Star)
            {
                txtOut.Text = "������";
            }
            else if (myObject is Comet)
            {
                txtOut.Text = "������";
            }*/
            txtOut.Text = myObject.GetInfo();
            // ������� ���������� � ���������� ������ �� �����
            ShowInfo();
        }
    }
}
