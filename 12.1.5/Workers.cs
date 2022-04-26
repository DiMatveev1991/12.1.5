    using System;
    using System.Threading;
    
    namespace unit12._1._5
    {
        public class Worker : User
        {
            public void ShowAds()
            {
                if (IsPremium == true)
                {
                    Console.WriteLine("Удачного просмотра");
                }
                else
                {
                    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
                    // Остановка на 1 с
                    Thread.Sleep(1000);

                    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
                    // Остановка на 2 с
                    Thread.Sleep(2000);

                    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
                    // Остановка на 3 с
                    Thread.Sleep(3000);
                }
            }
        }
    }


