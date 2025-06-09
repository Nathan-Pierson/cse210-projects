class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    ReflectionActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }
}