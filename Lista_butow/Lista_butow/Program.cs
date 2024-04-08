
static void Main(string[] args)
{
    List<Shoe> shoeCloset = new List<Shoe>();

    shoeCloset.Add(new Shoe()
    {
        Style = Style.Sneakers,
        Color = "Czarny"
    });
    shoeCloset.Add(new Shoe()
    {
        Style = Style.Clogs,
        Color = "Brązowy"
    });
    shoeCloset.Add(new Shoe()
    {
        Style = Style.Sandals,
        Color = "Czerwony"
    });

    int numberOfShoes = shoeCloset.Count;
    foreach(Shoe shoe in shoeCloset)
    {
        shoe.Style = Style.Flipflops;
        shoe.Color = "Pomarańczowy";
    }

    shoeCloset.RemoveAt(4);

    Shoe thirdShoe = shoeCloset[2];
    Shoe secondShoe = shoeCloset[1];
    shoeCloset.Clear();

    shoeCloset.Add(thirdShoe);
    if (shoeCloset.Contains(secondShoe))
    {
        Console.WriteLine("A to ci niespodzianka");
    }
}
public class Shoe
{
    public Style Style;
    public string Color;
}
public enum Style
{
    Sneakers,
    Loafers,
    Sandals,
    Flipflops,
    Wingtips,
    Clogs
}