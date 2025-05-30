class Reference
{
    private string _referenceBook;
    private string _referenceChapter;
    private string _referenceVerses;

    //Constructor if nothing is called in parameters.
    public Reference()
    {
        _referenceBook = "n/a";
        _referenceChapter = "n/a";
        _referenceVerses = "n/a";
    }
    public void setReference(string reference)
    {
        string[] parts = reference.Split(" ");
        string[] moreParts = parts[1].Split(":");
        _referenceBook = parts[0];
        _referenceChapter = moreParts[0];
        _referenceVerses = moreParts[1];
    }

    public string getReference()
    {
        string reference = $"{_referenceBook} {_referenceChapter}:{_referenceVerses} ~";
        return reference;
    }
}