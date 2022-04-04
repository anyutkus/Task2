public class PracticalLesson : Training
{
    public string Condition { get; set; }
    public string Solution { get; set; }

    public PracticalLesson(string description = "", string condition = "", string solution = "")
    {
        Description = description;
        Condition = condition;
        Solution = solution;
    }
}
