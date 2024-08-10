using System;

namespace _08.OldLibrary
{
    internal class Program
    {
        /*
         Ани отива до родния си град след много дълъг период извън страната. Прибирайки се вкъщи тя вижда старата библиотека на баба си и си спомня за любимата си книга. Помогнете на Ани, като напишете програма в която тя въвежда търсената от нея книга(текст). Докато Ани не намери любимата си книга или не провери всички в библиотеката, програмата трябва да чете всеки път на нов ред името на всяка следваща книга (текст). Книгите в библиотеката са свършили щом получите текст "No More Books".
            •	Ако не открие търсената книгата да се отпечата на два реда: 
            o	"The book you search is not here!"
            o	"You checked {брой} books."
            •	Ако открие книгата си се отпечатва един ред:
            o	"You checked {брой} books and found it."  

         
         */
        static void Main(string[] args)
        {
            string searchedBook = Console.ReadLine();
            string currentBook = "";
            int booksCount = 0;

            while (searchedBook != "No More Books")
            {
                if (currentBook == "No More Books")
                {
                    break;
                }
                if (currentBook == searchedBook)
                {
                    //the current book is found and we dont count it in the final result
                    booksCount--;
                    Console.WriteLine($"You checked {booksCount} books and found it!");
                    break;
                }
                
                
                
                currentBook = Console.ReadLine();
                booksCount++;

            }
            if (currentBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                //No More Books is counted as a book so we need to -- it 
                booksCount--;
                Console.WriteLine($"You checked {booksCount} books.");
            }
        }
    }
}
