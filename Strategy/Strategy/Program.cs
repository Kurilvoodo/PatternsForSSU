using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Behavior;
namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Создаем Ситха
            Sith DartMaul = new Sith(new DarkKnight());
            DartMaul.DoSomething(); //проверяем работоспособность

            //Меняем стратегию
            DartMaul.Stance = new Inquisitor();
            DartMaul.DoSomething();

            //Создаем Джедая
            Jedi QuaiGonJhin = new Jedi(new QuaiGon());
            //проверяем что делает Джедай
            QuaiGonJhin.DoSomething();

            QuaiGonJhin.Stance = new BlueObi();
            QuaiGonJhin.DoSomething();

            Console.ReadLine();
        }
    }
}
