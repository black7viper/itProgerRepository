namespace Learn
{
    internal class Indexators
    {
        public static void Main()
        {
            Team Portsmouth = new Team();
            Portsmouth.footballers = new Footballer[2];
            Portsmouth.footballers[0]  = new Footballer(9, "Papa Bouba Diop");
            Portsmouth.footballers[1] = new Footballer(1, "Van Der Sar");

            Footballer footballer = Portsmouth[0];
        }
    }

    public class Footballer
    {
        int number;
        string name;
        
        public Footballer(int Number, string Name)
        {
            this.number = Number;
            this.name = Name;
        }
    }

    public class Team
    {
        public Footballer[]? footballers;
        public Footballer this[int index]
        {
            get
            {
                if (footballers?.Length <= index)
                { 
                    throw new ArgumentOutOfRangeException(); 
                }
                else
                { 
                    return footballers?[index] ?? throw new Exception("Unhadled exception"); 
                }
            }
            set { }
        }
    }


}
