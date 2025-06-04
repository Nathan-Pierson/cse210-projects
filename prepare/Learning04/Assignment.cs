public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string getStudentName()
    {
        string student = $"{_studentName}";
        return student;
    }

    public string getTopic()
    {
        string topic = $"{_topic}";
        return topic;
    }
    
        public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
}