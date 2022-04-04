public class Lection : Training
{
    public string Topic { get; set; }

    public Lection(string description = "", string topic = "")
    {
        Description = description;
        Topic = topic;
    }

}

