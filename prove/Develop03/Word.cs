class Word
{
    private string _word;
    private bool _visible;

    public Word(string text)
    {
        _word = text;
        _visible = true;
    }
    //This hides the words by setting the _visible to false
    public void hide()
    {
        _visible = false;
    }
    //This returns the boolean of _visible so that it will only choose words to hide that are visible
    public bool getVisible()
    {
        return _visible;
    }


    public string getText()
    {
        if (_visible)
        {
            return _word;
        }
        else
        {
            // Build a string of underscores and return that string.
            int underscoreLength = _word.Length;
            string underscore = new string('_', underscoreLength);
            return underscore;

        }
    }
}
