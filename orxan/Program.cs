using System;

namespace orxan
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping();
            Pong pong = new Pong();
            ping.Notify += metod;
            pong.Notify += metod;
            for (int i = 0; i < 3; i++)
            {
                ping.Otbil("пинг");
                pong.Otbil("понг");
            }
            static void metod(string message)
            {
                Console.WriteLine(message);
            }
        }
    }
    class Pong
    {
        public delegate void pong(string message);
        public event pong Notify;
        public void Otbil(string a)
        {
                Notify?.Invoke($"произошел {a}");
        }
    }
    class Ping
    {
        public delegate void ping(string message);
        public event ping Notify;
        public void Otbil(string a)
        {
                Notify?.Invoke($"произошел {a}");
        }
    }
}
