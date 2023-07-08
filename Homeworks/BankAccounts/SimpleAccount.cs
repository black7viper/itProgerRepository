namespace itProger
{
    public class SimpleAccount : Account
    {
        public long sum;

        public SimpleAccount()
        {
            sum = 0;
        }

        public override long Sum
        {
            get => sum;
            set => sum = value;
        }

        public override bool add(long amount)
        {
            sum += amount;
            return true;
        }

        public override long getBalance()
        {
            return sum;
        }

        public override bool pay(long amount)
        {
            if (amount > sum)
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
                account.add(amount);
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
