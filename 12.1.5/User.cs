using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit12._1._5
{
    public class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }

        public User()
        {
            Console.WriteLine("Введите логин:");
            Login = Console.ReadLine();

            Console.WriteLine("Введите имя:");
            Name = Console.ReadLine();

            var premiumHas = new Dictionary<string, string>()
            {
                {"Foma", "Dima"},
                {"drowWaker", "Egor" },
                {"grishq1992", "grisha" },
            };
            foreach (KeyValuePair<string, string> pair in premiumHas)
            {
                if (pair.Key==Login && pair.Value == Name)
                {
                    IsPremium = true;
                    break;
                }
                else 
                {
                    IsPremium = false;
                }
            }
        }
    }
}

