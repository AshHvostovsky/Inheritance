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

            // пройдемся по всему списку
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

            // а ну и вывести все это надо на форму
            txtInfo.Text = "Плнт\tЗвзд\tКомт"; // буквы экнмлю, чтобы влезло на форму
            txtInfo.Text += "\n";
            txtInfo.Text += String.Format("{0}\t{1}\t{2}", planetsCount, starsCount, cometsCount);
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            // если список пуст, то напишем что пусто и выйдем из функции
            if (this.objectsList.Count == 0)
            {
                txtOut.Text = "Пусто Q_Q";
                return;
            }

            // взяли первый объект
            var myObject = this.objectsList[0];
            // тут вам не реальность, взятие это на самом деле создание указателя на область в памяти
            // где хранится экземпляр класса, так что если хочешь удалить, делай это сам
            this.objectsList.RemoveAt(0);

            // ну а теперь предложим покупателю его объект

            /*
            if (myObject is Planet)
            {
                txtOut.Text = "Планета";
            }
            else if (myObject is Star)
            {
                txtOut.Text = "Звезда";
            }
            else if (myObject is Comet)
            {
                txtOut.Text = "Комета";
            }*/
            txtOut.Text = myObject.GetInfo();
            // обновим информацию о количестве товара на форме
            ShowInfo();
        }
    }
}
