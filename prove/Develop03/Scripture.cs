using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        _words = new List<Word>();

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
{
    Random rand = new Random();

    List<Word> visibleWords = new List<Word>();

    foreach (Word word in _words)
    {
        if (!word.IsHidden())
        {
            visibleWords.Add(word);
        }
    }

    for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
    {
        int index = rand.Next(visibleWords.Count);

        visibleWords[index].HideWord();

        visibleWords.RemoveAt(index);
    }
}
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
    public string GetDisplayText()
    {
        string text = _reference.GetDisplay() + " ";

        foreach (Word word in _words)
        {
            text += word.GetDisplay() + " ";
        }

        return text;
    }

}
