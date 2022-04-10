public class Lection : Lesson
{
    public string Topic { get; set; }

    public Lection(string description = "", string topic = "")
    {
        Description = description;
        Topic = topic;
    }

    public Lection Clone()
    {
        Lection lection = new();
        lection.Description = this.Description;
        lection.Topic = this.Topic;

        return lection;
    }
}

