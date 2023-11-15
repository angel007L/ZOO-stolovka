using System;
using ZOO;
using static ZOO.Zoo;

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = new Animal[5];

        Penguin penguin = new Penguin("стас", 5);
        Monkey monkey = new Monkey("даня", 3);
        Kangaroo kangaroo = new Kangaroo("артем", 2);
        Shark shark = new Shark("ярослейв", 10);
        Classmate classmate = new Classmate("Степанидзе", 12);

        animals[0] = penguin;
        animals[1] = monkey;
        animals[2] = kangaroo;
        animals[3] = shark;
        animals[4] = classmate;

        foreach (Animal animal in animals)
        {
            Console.WriteLine(animal.MakeSound());
        }

        Console.WriteLine("Вам предстоит выбрать зверушку:\r\n" + "1. Стас\r\n" + "2. Даня\r\n" + "3. Артем\r\n" + "4. Ярослейв\r\n" + "5. Степанидзе\r\n");
        var choice = Convert.ToInt32(Console.ReadLine());

        if (choice >= 1 && choice <= 5)
        {
            Animal selectedAnimal = animals[choice - 1];
            Console.WriteLine($"Вы взяли за руку {selectedAnimal.Name} ({selectedAnimal.Species}) и направляетесь в столовую.");

            Random random = new Random();
            IFoodProvider foodProvider = random.Next(2) == 0 ? (IFoodProvider)new GoodCook() : (IFoodProvider)new FancyCook();

            Console.WriteLine($"В столовой вас обслуживает повариха.сегодня {foodProvider.ProvideFood()}");

            if (foodProvider.IsEvil())
            {
                Console.WriteLine("Выберите действие:\r\n" + "1. Высказать все поварихе\r\n" + "2. Промолчать\r\n");
                var actionChoice = Convert.ToInt32(Console.ReadLine());

                if (actionChoice == 1)
                {
                    Console.WriteLine("Выскажите этой хорошей женщине всё ,что вы о ней думаете.");
                    Console.ReadLine();
                    Console.WriteLine("Вы решаете съесть приготовленную еду. Повариха говорит: 'Куда вам есть, посмотрите на себя!'");
                }
                else if (actionChoice == 2)
                {
                    Console.WriteLine("Вы промолчали, и повариха выдает вам порцию еды.");
                }
                else
                {
                    Console.WriteLine("Неправильный выбор!");
                }
            }
            else
            {
                Console.WriteLine("Вы решаете съесть приготовленную еду\r\n"+" Повариха делает вам комплимент.\r\n");
            }
        }
        else
        {
            Console.WriteLine("Неправильный выбор!");
        }

        Console.ReadLine();
    }
}