using System;
using System.Runtime.CompilerServices;

namespace _13.Salary
{
    internal class Program
    {
        /*
         
         Шеф на компания забелязва че все повече служители прекарват  време в сайтове, които ги разсейват.  
        За да предотврати това, той въвежда изненадващи проверки на отворените табове на браузъра на служителите си. 
        Според отворения сайт в таба се налагат следните глоби:
        •	"Facebook" -> 150 лв.
        •	"Instagram" -> 100 лв.
        •	"Reddit" -> 50 лв.
        От конзолата се четат два реда:
        •	Брой отворени табове в браузъра n - цяло число в интервала [1...10]
        •	Заплата - число в интервала [500...1500]
        След това n – на брой пъти се чете име на уебсайт – текст
        Изход
        •	Ако по време на проверката заплатата стане по-малка или равна на 0 лева, на конзолата се изписва 
        "You have lost your salary." и програмата приключва. 
        •	В противен случай след проверката на конзолата се изписва остатъкът от заплатата (да се изпише като цяло число).

         */
        static void Main(string[] args)
        {
            Console.Write("Number of tabs opened: ");
            int tabsOpened = int.Parse(Console.ReadLine());

            Console.Write("Salary: ");
            int salary = int.Parse(Console.ReadLine());

            int finalFine = 0;

            Console.WriteLine("Sites names: ");
            for (int i = 1; i <= tabsOpened; i++)
            {
                string sitesNames = Console.ReadLine();
                if (sitesNames =="Facebook")
                {
                    int facebookFine = 150;
                    finalFine += facebookFine;
                }
                else if (sitesNames == "Instagram")
                {
                    int instagramFine = 100;
                    finalFine += instagramFine;
                }
                else if (sitesNames == "Reddit")
                {
                    int redditFine = 50;
                    finalFine += redditFine;
                }
                if (salary <= finalFine)
                {
                    Console.WriteLine("You have lost your salary.");
                }
            }
            Console.WriteLine(salary-finalFine);
        }
    }
}
