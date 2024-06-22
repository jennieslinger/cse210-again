using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        string _promptText = PromptGenerator.GetRandomPrompt();
        Console.WriteLine("${_promptText}: {entry.EntryText}");
        _entries.Add(entry);
    }

    public void DisplayAllEntries()
    {
        Console.WriteLine("\n---Journal Entries---");
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string saveFilename)
    {
        using (StreamWriter outputFile = new StreamWriter(saveFilename))
        {

        }

    }

    public void LoadFromFile(string loadFilename)
    {
        string[] lines = File.ReadAllLines(loadFilename);
        for (int i = 0; 1 < lines.Length; i += 3)
        {
            string dateLine = lines[i];
            string promptLine = lines[i + 1];
            string entryLine = lines[i + 2];

            string entryDate = dateLine.Substring(6);
            string promptText = promptLine.Substring(7);
            string entryText = entryLine.Substring(8);
        }

    }
}