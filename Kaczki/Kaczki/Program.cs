static void Main(string[] args)
{

    List<Duck> ducks = new List<Duck>() {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };

    DuckComparerBySize sizeComparer = new DuckComparerBySize();
    ducks.Sort(sizeComparer);
    PrintDucks(ducks);

    DuckComparerByKind kindComparer = new DuckComparerByKind();
    ducks.Sort(kindComparer);
    PrintDucks(ducks);

    DuckComparer comparer = new DuckComparer();

    comparer.SortBy = SortCriteria.KindThenSize;
    ducks.Sort(comparer);
    PrintDucks(ducks);

    comparer.SortBy = SortCriteria.SizeThenKind;
    ducks.Sort(comparer);
    PrintDucks(ducks);

    // This keeps the output from disappearing before you can read it
    Console.ReadKey();

    static void PrintDucks(List<Duck> ducks)
    {
        foreach (Duck duck in ducks)
        {
            Console.WriteLine(duck);
        }
        Console.WriteLine("End of ducks!");
    }

}


/*
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
*/

class Duck : IComparable<Duck>
{
    public int Size;
    public KindOfDuck Kind;

    public int CompareTo(Duck duckToCompare)
    {
        if (this.Size > duckToCompare.Size)
            return 1;
        else if (this.Size < duckToCompare.Size)
            return -1;
        else
            return 0;
    }

    public override string ToString()
    {
        return "A " + Size + " inch " + Kind.ToString();
    }
}
class DuckComparerByKind : IComparer<Duck>
{
    public int Compare(Duck x, Duck y)
    {
        if (x.Kind < y.Kind)
            return -1;
        if (x.Kind > y.Kind)
            return 1;
        else
            return 0;
    }
}
class DuckComparerBySize : IComparer<Duck>
{
    public int Compare(Duck x, Duck y)
    {
        if (x.Size < y.Size)
            return -1;
        if (x.Size > y.Size)
            return 1;
        return 0;
    }
}
class DuckComparer : IComparer<Duck>
{
    public SortCriteria SortBy = SortCriteria.SizeThenKind;

    public int Compare(Duck x, Duck y)
    {
        if (SortBy == SortCriteria.SizeThenKind)
            if (x.Size > y.Size)
                return 1;
            else if (x.Size < y.Size)
                return -1;
            else
                if (x.Kind > y.Kind)
                return 1;
            else if (x.Kind < y.Kind)
                return -1;
            else
                return 0;
        else
            if (x.Kind > y.Kind)
            return 1;
        else if (x.Kind < y.Kind)
            return -1;
        else
            if (x.Size > y.Size)
            return 1;
        else if (x.Size < y.Size)
            return -1;
        else
            return 0;
    }
}
public enum KindOfDuck
{
    Mallard,
    Muscovy,
    Decoy
}
enum SortCriteria
{
    SizeThenKind,
    KindThenSize,
}

