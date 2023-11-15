namespace ZOO
{
    public interface IFoodProvider
    {
        string ProvideFood();
        bool IsEvil();
    }

    public class FancyCook : IFoodProvider
    {
        private readonly string[] menu = { "Пельмени ", "вкусные булочки", "суп с тефтельками" };

        public string ProvideFood()
        {
            Random random = new Random();
            int foodChoice = random.Next(1, menu.Length + 1);

            if (foodChoice >= 1 && foodChoice <= menu.Length)
            {
                return menu[foodChoice - 1];
            }

            return "Неправильный выбор!";
        }

        public bool IsEvil()
        {
            return true;
        }
    }

    public class GoodCook : IFoodProvider
    {
        private readonly string[] menu = { "Рис с подливой", "Макароны ", "Салаn" };

        public string ProvideFood()
        {
            Random random = new Random();
            int foodChoice = random.Next(1, menu.Length + 1);

            if (foodChoice >= 1 && foodChoice <= menu.Length)
            {
                return menu[foodChoice - 1];
            }

            return "Неправильный выбор!";
        }

        public bool IsEvil()
        {
            return false;
        }
    }

    public class Zoo
    {
        public class Animal
        {
            public string Name;
            public int Age;
            public string Species;
            public string Sound;

            public Animal(string name, int age, string species, string sound)
            {
                Name = name;
                Age = age;
                Species = species;
                Sound = sound;
            }

            public virtual string MakeSound()
            {
                return $"{Name} {Species} издает звук: {Sound}";
            }
        }

        public class Penguin : Animal
        {
            public Penguin(string name, int age) : base(name, age, "Пингвин", "кхм")
            {
            }
        }

        public class Monkey : Animal
        {
            public Monkey(string name, int age) : base(name, age, "Обезьяна", "у-у-у")
            {
            }
        }

        public class Shark : Animal
        {
            public Shark(string name, int age) : base(name, age, "Акула", "Факинг слейм")
            {
            }
        }

        public class Classmate : Animal
        {
            public Classmate(string name, int age) : base(name, age, "Одноклассник", "ЫЫЫЫ БЛЕНДЕР!")
            {
            }

            public override string MakeSound()
            {
                return $"{Name} одноклассник издает звук: {Sound}";
            }
        }

        public class Kangaroo : Animal
        {
            public Kangaroo(string name, int age) : base(name, age, "Кенгуру", "Прыг скок")
            {
            }
        }
    }
}