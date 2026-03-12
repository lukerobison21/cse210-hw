public class Word
{
    private string _content;
    private bool _isHidden;

    public Word(string content)
    {
        _content = content;
        _isHidden = false;
    }
    
    public void HideWord()
    {
        _isHidden = true;
    }
    public void ShowWord()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplay()
    {
        if (_isHidden)
        {
            return new string('_', _content.Length);
        }
        else
        {
            return _content;
        }
    }
}