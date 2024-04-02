using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Modules
{
    internal abstract class Account
    {
        public abstract string ID { get;protected set; }
        public abstract void LogIn(string login, string password);

    }
}
