using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private bool _completelyHidden;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //spilt text into word objects
        string[] wordTexts = text.Split(new char[] { ' ', ',', '.', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (string wordText in wordTexts)
        {
            _words.Add(new Word(wordText));
        }

        _completelyHidden = false;
    }


    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide(); //Replace word with underscores
        }
        _completelyHidden = CheckIfCompletelyHidden();
    }

    private bool CheckIfCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetDisplayText() != "_____")
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            if (word.IsHidden())
                displayWords.Add("_______");
            else
                displayWords.Add(word.GetDisplayText());
        }

        return string.Join(" ", displayWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.GetDisplayText() != "______")
            {
                return false;
            }
        }
        return true;
    }
}