class Scripture
{
    private List<Word> _words;
    private static Random _random;

    //This constructor sets the _words 
    public Scripture(string text)
    {
        _words = new List<Word>();
        _random = new Random();
        string[] words = text.Split(" ", StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    //Random words will take the text of words and choose three random words that will then
    //be hidden in another function in the word class
    public void setRandomWords()
    {
        List<Word> text = new List<Word>();
        List<Word> randomWords = new List<Word>();
        foreach (Word wordObject in _words)
        {
            if (wordObject.getVisible())
            {
                text.Add(wordObject);
            }
        }

        while (randomWords.Count < 3)
            if (text.Count == 0)
            {
                break;
            }
            else
            {
                int randomIndex = _random.Next(0, text.Count);
                Word t = text[randomIndex];
                randomWords.Add(t);
                t.hide();
            }
    }

    public List<string> getText()
    {
        List<string> finalScripture = new List<string>();

        foreach (Word wordObject in _words)
        {
            string part = wordObject.getText();
            finalScripture.Add(part);
        }

        return finalScripture;
    }

    public bool isCompletlyHidden()
    {
        foreach (Word wordObject in _words)
        {
            if (wordObject.getVisible())
            {
                return false;
            }
        }
        return true;
    }
}