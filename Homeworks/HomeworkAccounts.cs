using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger
{
    internal class HomeworkAccounts
    {
        public static void Main()
        {
            SimpleAccount sa1 = new SimpleAccount();
            SimpleAccount sa2 = new SimpleAccount();
            long l1 = 400;
            long l2 = 100;
            CreditAccount ca1 = new CreditAccount(l1);
            CreditAccount ca2 = new CreditAccount(l1);

            Console.WriteLine(sa1.add(500));
            Console.WriteLine(sa1.getBalance());
            Console.WriteLine(sa2.add(100));
            Console.WriteLine(sa2.getBalance());
            Console.WriteLine(sa1.add(50));
            Console.WriteLine(sa1.getBalance());
            Console.WriteLine(ca1.add(50));
            Console.WriteLine(ca1.pay(401));
            Console.WriteLine(ca1.transfer(ca2, 50));
            Console.WriteLine(ca1.getBalance());
            Console.WriteLine(ca2.getBalance());
            Console.WriteLine(ca1.pay(350));
            Console.WriteLine(ca1.getBalance());
            Console.WriteLine(ca1.pay(40));
            Console.WriteLine(ca1.getBalance());
            Console.WriteLine(ca1.pay(20));

            long l3 = 100;
            CreditAccount ca3 = new CreditAccount(1000);
            Console.WriteLine(ca3.add(2000));
            Console.WriteLine(ca3.getBalance());

        }

    }
}
