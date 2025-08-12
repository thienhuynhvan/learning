public class NationalID
{
    public string Id { get; set; }

    public NationalID(string id)
    {
        Id = id;
    }
}

public static NationalID CreateId(string nid)
{
    return new NationalID(nid);
}

public static void Main()
{
    NationalID nid = CreateId("123456789");
    Console.WriteLine($"Stored ID: {nid.Id}");
}