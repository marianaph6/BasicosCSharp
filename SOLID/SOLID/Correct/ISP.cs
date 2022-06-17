using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Correct
{
    internal class ISP
    {
        public interface IOrder
        {
            void AddToCart();
        }

        public interface IOnlineOrder
        {
            void CCProcess();
        }

        public class OnlineOrder : IOrder, IOnlineOrder
        {
            public void AddToCart()
            {
                //Do Add to Cart
            }

            public void CCProcess()
            {
                //process through credit card
            }
        }

        public class OfflineOrder : IOrder
        {
            public void AddToCart()
            {
                //Do Add to Cart
            }
        }

    }
}
