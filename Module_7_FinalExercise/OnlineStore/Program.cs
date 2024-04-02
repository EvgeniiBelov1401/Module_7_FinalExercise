using OnlineStore.Modules;
using System.Reflection.Emit;

namespace OnlineStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Приветствие
            Account myAccount = new YourAccount();
        
            //Логин/пароль
        LabelLoginIn:
            Console.Write("Логин: ");
            string log=Console.ReadLine();
            if (string.IsNullOrEmpty(log))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Необходимо ввести Логин");
                Console.ForegroundColor = ConsoleColor.White;
                goto LabelLoginIn;
            }
        LabelPassIn:
            Console.Write("Пароль: ");
            string pass = Console.ReadLine();
            if (string.IsNullOrEmpty(pass))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Необходимо ввести Пароль");
                Console.ForegroundColor = ConsoleColor.White;
                goto LabelPassIn;
            }
            myAccount.LogIn(log,pass);
            if (YourAccount.isYourAccount)
            {
                //Заказ. Ассортимент
                Order order = new Order();
                Console.ReadLine();
                Console.Clear();

                //Заказ. Способ доставки
                order.ShowDelivery();
                order.GetDelivery();
            }
            else
            {
                goto LabelLoginIn;
            }
            
            Console.ReadLine();
            Console.Clear();
            //Заказ. Информация об оформленном заказе
            Order.CompleteOrder(myAccount.ID);
           

        }
    }
}
