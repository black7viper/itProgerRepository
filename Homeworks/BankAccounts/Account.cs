using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itProger
{
    public abstract class Account
    {
        public abstract long Sum { get; set; }
        public abstract bool add(long amount);
        public abstract bool pay(long amount);
        public abstract bool transfer(Account account, long amount);
        public abstract long getBalance();

    }
}
