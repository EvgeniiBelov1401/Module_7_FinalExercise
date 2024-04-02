using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Modules
{
    internal class ShopDelivery : Delivery
    {
        private string nameDelivery = "Самовывоз из магазина";
        private string adress = "Уездный город N, ул.Самовывозная, д.2";
        private int daysForDelivery = 1;

        public override DateTime DeliveryDate 
        {
            get
            {
                return DateTime.Now.AddDays(daysForDelivery);
            } 
                protected set
            {

            }  
        }

        public override string ShowAdress()
        {
            return adress;
        }

        public override string ShowNameDelivery()
        {
            return nameDelivery;
        }
    }
}
