using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {

        List<CosmicObject> objectsList = new List<CosmicObject>();
        ImageList imageList;
        public Form1()
        {
            InitializeComponent();

            ShowInfo();

            // ������� ImageList � ��������� �����������
            this.imageList = new ImageList();

            // ����������� ����������� � ListView
            listView1.LargeImageList = imageList;

            imageList.Images.Add("meteor", Properties.Resources.meteor);
            imageList.Images.Add("star", Properties.Resources.star);
            imageList.Images.Add("planet", Properties.Resources.planet);
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


            listView1.Items.Clear();


            // ��������� �� ����� ������
            foreach (var myObject in this.objectsList)
            {


                if (myObject is Planet)
                {
                    listView1.Items.Add(new ListViewItem("�������", "planet"));

                    planetsCount += 1;
                }
                else if (myObject is Star)
                {
                    listView1.Items.Add(new ListViewItem("������", "star"));
                    starsCount += 1;
                }
                else if (myObject is Comet)
                {
                    listView1.Items.Add(new ListViewItem("������", "meteor"));

                    cometsCount += 1;
                }
            }

            // � �� � ������� ��� ��� ���� �� �����
            txtInfo.Text = String.Format("�������: {0}.\t������: {1}.\t������: {2}", planetsCount, starsCount, cometsCount);
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
