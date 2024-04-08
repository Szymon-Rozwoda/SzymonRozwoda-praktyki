static void Main(string[] args)
{
    List<Duck> ducks = new List<Duck>() {
        new Duck()
        {
            Kind = KindOfDuck.Mallard, Size = 17
        },
        new Duck()
        {
            Kind = KindOfDuck.Muscovy, Size = 18
        },
        new Duck()
        {
            Kind = KindOfDuck.Decoy, Size = 14
        },
        new Duck()
        {
            Kind = KindOfDuck.Muscovy, Size = 11
        },
        new Duck()
        {
            Kind = KindOfDuck.Mallard, Size = 14
        },
        new Duck()
        {
            Kind = KindOfDuck.Decoy, Size = 13
        },
    };
    ducks.Sort();
    Console.WriteLine("linia");
    Console.ReadKey();
}
class Duck() : IComparable<Duck>{
    public int Size;
    public KindOfDuck Kind;


    public int CompareTo(Duck duckToCompare)
    {
        if(this.Size > duckToCompare.Size)
        {
            return 1;
        }
        else if(this.Size < duckToCompare.Size)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
public enum KindOfDuck
{
    Mallard,
    Muscovy,
    Decoy
}

