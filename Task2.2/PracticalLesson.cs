public class PracticalLesson : Lesson
{
    public string Condition { get; set; }
    public string Solution { get; set; }

    public PracticalLesson(string description = "", string condition = "", string solution = "")
    {
        Description = description;
        Condition = condition;
        Solution = solution;
    }

    public PracticalLesson Clone()
    {
        PracticalLesson practical = new();
        practical.Description = this.Description;
        practical.Condition = this.Condition;
        practical.Solution = this.Solution;

        return practical;
    }
}
