public class WritingAssignment : Assignment
{
    private string _title;

    
    public WritingAssignment(string sName, string topic, string title)
        : base(sName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string sName = GetSName();

        return $"{_title} by {sName}";
    }
}