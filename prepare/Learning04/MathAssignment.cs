public class MathAssignment : Assignment
{
    //variable specific to MathAssignment
    private string _textbookSection;
    private string _problems;

    //constructor specific to MathAssignment
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic) //base class constructor
    {
        this._textbookSection = textbookSection;
        this._problems = problems;
    }

    //method specific to MathAssignment
    public string GetHomeworkList()
    {
        return $"Section: {this._textbookSection} Problems: {this._problems}";
    }
}