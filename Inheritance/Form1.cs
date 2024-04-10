using System.Windows.Forms;

namespace Inheritance
{
    public partial class Form1 : Form
    {

        private List<CosmicObject> objectsList = new List<CosmicObject>();
        private ImageList imageList;
        public Form1()
        {
            InitializeComponent();

            //Ставим окно на центр экрана
            this.StartPosition = FormStartPosition.CenterScreen;

            // Выведем строчку с количеством объектов
            ShowInfo();

            // Создаем ImageList
            this.imageList = new ImageList();

            //Добавляем в список изображения
            imageList.Images.Add("meteor", Properties.Resources.meteor);
            imageList.Images.Add("star", Properties.Resources.star);
            imageList.Images.Add("planet", Properties.Resources.planet);

            // Присваиваем изображения в ListView
            listView1.LargeImageList = imageList;

        }

        private void btnRefill_Click(object sender, EventArgs e)
        {
            this.objectsList.Clear();
            var rnd = new Random();

            for (var i = 0; i < 10; ++i)
            {
                switch (rnd.Next() % 3) // генерирую случайное число от 0 до 2 (ну остаток от деления на 3)
                {
                    case 0: // если 0, то планета
                        this.objectsList.Add(Planet.Generate());
                        break;
                    case 1: // если 1 то звезда
                        this.objectsList.Add(Star.Generate());
                        break;
                    case 2: // если 2 то комета
                        this.objectsList.Add(Comet.Generate());
                        break;
                        // появление других чисел маловероятно
                }
            }
            ShowInfo();
        }
        private void ShowInfo()
        {
            // заведем счетчики под каждый тип
            int planetsCount = 0;
            int starsCount = 0;
            int cometsCount = 0;


            listView1.Items.Clear();


            // пройдемся по всему списку
            foreach (var myObject in this.objectsList)
            {


                if (myObject is Planet)
                {
                    listView1.Items.Add(new ListViewItem("Планета", "planet"));

                    planetsCount += 1;
                }
                else if (myObject is Star)
                {
                    listView1.Items.Add(new ListViewItem("Звезда", "star"));
                    starsCount += 1;
                }
                else if (myObject is Comet)
                {
                    listView1.Items.Add(new ListViewItem("Комета", "meteor"));

                    cometsCount += 1;
                }
            }

            // а ну и вывести все это надо на форму
            txtInfo.Text = String.Format("Планеты: {0}.\tЗвезды: {1}.\tКометы: {2}", planetsCount, starsCount, cometsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.objectsList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            // взяли первый объект, создали указатель на этот объект
            var myObject = this.objectsList[0];
            // удаляем объект из списка
            this.objectsList.RemoveAt(0);

            // выведем информацию об объекте
            txtOut.Text = myObject.GetInfo();
            // обновим информацию о количестве товара на форме
            ShowInfo();
        }

    }
}
