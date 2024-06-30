public class Reference
{
    public string _book;
    public int _chapter;
    public int _verse;
    public int _startVerse;
    public int _endVerse;
    bool _isMultiverse; //Added if referene is mulitple verses

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        _isMultiverse = true;
    }

    public string GetDisplayText()
    {
        if (_isMultiverse)
        {
            return $"{_book} {_chapter}: {_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}: {_verse}";
        }
    }
}