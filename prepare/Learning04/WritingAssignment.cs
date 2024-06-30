public class WritingAssignment : Assignment
{
    //variable specific to WritingAssignment
    private string _title;

    //constructor specific to WritingAssignment
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic) //base class constructor
    {
        this._title = title;
    }

    //method specific to WritingAssignment
    public string GetWritingInformation()
    {
        //call getter to get private _studentName
        string studentName = GetStudentName();
        return $"{this._title} by {studentName}";
    }
}