public class MathAssignment : Assignment
{
    private string _textSection;
    private string _problems;

    
    public MathAssignment(string sName, string topic, string textSection, string problems)
        : base(sName, topic)
    {
 
        _textSection = textSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textSection} Problems {_problems}";
    }
}