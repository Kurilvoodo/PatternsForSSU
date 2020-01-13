using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;
using AbstractFactory.Factory.Factory;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client _client = null;
            _client = new Client(new LaserFactory());
            _client.Run();
            Console.WriteLine();
            _client = new Client(new LightSaberFactory());
            _client.Run();
            Console.WriteLine();
            
            _client = new Client(new LMGFactory());
            _client.Run();
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
