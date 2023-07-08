namespace itProger
{
    public class CreditAccount : Account
    {
        public long sum;
        public long limit;

        public CreditAccount(long limit)
        {
            sum = 0;
            this.limit = -limit;
        }

        public override long Sum { get => sum; set => sum = value; }

        public override bool add(long amount)
        {
            if (sum + amount > 0)
            {
                return false;
            }
            else
            {
                sum += amount;
                return true;
            }
        }

        public override long getBalance()
        {
            return sum;
        }

        public override bool pay(long amount)
        {
            if (sum - amount < limit)
            {
                return false;
            }
            else
            {
                sum -= amount;
                return true;
            }
        }

        public override bool transfer(Account account, long amount)
        {
            if (pay(amount))
            {
                if (account.add(amount))
                {
                    return true;
                }
                else
                {
                    add(amount);
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

    }
}
