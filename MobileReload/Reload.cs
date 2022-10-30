using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileReload
{
    public class Reload
    {
        float dialogBalance=1000;
        float mobitelBalance=1000;

        public Reload()
        {
            while (true)
            {
                Console.WriteLine("======================");
                Console.WriteLine("Welcome to Self Reload");
                var number = GetMobileNumber();
                var reloadAmount = GetReloadAmount();
                var isConfirmd = GetSellerConfirmation();
                ApplyReload(isConfirmd);
            }
        }

        public void ApplyReload(bool isConfirmd)
        {
            if (isConfirmd)
            {

            }
            else
            {
                Console.WriteLine("Reload confirmation failed. Abort...")
            }
        }

        public long GetMobileNumber()
        {
            Console.WriteLine("Please insert your mobile number");
            var num=long.Parse(Console.ReadLine());  //reload input has numeric pad
            return num;
        }

        public float GetReloadAmount()
        {
            Console.WriteLine("Please insert reload amount");
            var amount = float.Parse(Console.ReadLine());  //reload input has numeric pad
            return amount;
        }

        public bool GetSellerConfirmation()
        {
            Console.WriteLine("Please confirm reload amount received");
            Console.WriteLine("press 1 to confirm");
            Console.WriteLine("press any other key to decline");
            var confirmReload = int.Parse(Console.ReadLine());  //reload input has numeric pad
            if (confirmReload==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
