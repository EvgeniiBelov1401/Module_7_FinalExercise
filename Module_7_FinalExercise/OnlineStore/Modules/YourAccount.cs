﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Modules
{
    internal class YourAccount : Account
    {
        private string id = "112233";
        private string login="login1234";  
        private string password="pass1234";
        private string loginIn=string.Empty;
        private string passwordIn=string.Empty;
        public static bool isYourAccount=false;
        public static string yourAdress = "Уездный город N, ул.Прямая, д.3, кв.4;";

        public override string ID 
        {
            get
            {
                return id;
            } 
            protected set
            {

            } 
        }

        static YourAccount()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Добро пожаловать в Интернет-магазин\n" +
                "Для входа в личный кабинет необходимо ввести логин/пароль:");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public override void LogIn()
        {
            LoginPassIn();
            if (this.login==loginIn && this.password == passwordIn)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Вам открыт доступ для заказа\n");
                Console.ForegroundColor = ConsoleColor.White;
                isYourAccount = true;
            }
            else
            {
                LoginPassIn();
            }
        }

        public override void LoginPassIn()
        {
            do
            {
                do
                {
                    Console.Write("Логин: ");
                    loginIn = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(loginIn));

                do
                {
                    Console.Write("Пароль: ");
                    passwordIn = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(passwordIn));
                
                if (this.login != loginIn || this.password != passwordIn)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неправильный логин и/или пароль");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            while (string.IsNullOrEmpty(loginIn) && string.IsNullOrEmpty(passwordIn));
        }
        
    }
}
