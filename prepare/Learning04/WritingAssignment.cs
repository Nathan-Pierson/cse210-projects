public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string getWritingInformation()
    {
        string text = $"{GetSummary()}\n{_title} by {getStudentName()}";
        return text;
    }
}