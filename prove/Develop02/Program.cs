using System;
using System.Linq;
using System.IO;
using System.Text;

//The Main program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Entry Program");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        //new journal
        Journal j = new Journal();

        int choice = 1;
        while(choice != 5)
        {
            DisplayMenu();
            string number = Console.ReadLine();
            choice = int.Parse(number);
            Console.WriteLine("------------------------------");
            Console.WriteLine();
            
            //This is the Write Prompt Option
            if (choice == 1)
            {
                //Picks prompt and gets user response
                string prompt = PickPrompt();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine(prompt);
                Console.WriteLine();
                Console.WriteLine("Write your response below.");
                string UserResponse = Console.ReadLine();
                Console.WriteLine();

                //Displays prompt and asks if they would like to edit it
                bool response = true;
                while (response)
                {
                    //Asks if user would like to edit their response
                    Console.WriteLine($"Your response is: {UserResponse}");
                    Console.WriteLine("Would you like to edit your response?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.Write(">");
                    string EditChoice = Console.ReadLine();
                    int Edit = int.Parse(EditChoice);

                    //This will be the option to edit the prompt.
                    if (Edit == 1)
                    {
                        //Calls the Edit string function in the edit string class.
                        UserResponse = EditString.StringEditor(UserResponse);
                    }
                    //This will be the option to save prompt to the entry class
                    else if (Edit == 2)
                    {
                        //Gets the current date
                        DateTime theCurrentTime = DateTime.Now;
                        string dateText = theCurrentTime.ToShortDateString();

                        //Enters the data into the entry class
                        Entry entry = new Entry();
                        entry._dateText = dateText;
                        entry._programPrompt = prompt;
                        entry._userResponse = UserResponse;

                        //Saves the entry data as a list in the journal entry
                        j._entries.Add(entry);
                        
                        //Displays their journal entry for them.
                        Console.WriteLine("------Journal Entry-------");
                        entry.DisplayEntry();

                        response = false;
                    }
                    //This is in case the user inputs a wrong choice.
                    else
                    {
                        Console.WriteLine("Choose a correct response.");
                    }
                }
            }
            //This is the Save Journal Entry Option
            else if (choice == 2)
            {
                //Gets the filename from the user
                Console.Write("What name do you want to call your filename? ");
                String fileName = Console.ReadLine();
                
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (Entry e in j._entries)
                    {
                        outputFile.WriteLine($"{e._dateText}|{e._programPrompt}|{e._userResponse}");
                    }
                }

            }
            //This is the Load Journal Entry Option
            else if (choice == 3)
            {
                //Gets file name and saves the data to a string
                Console.Write("What file do you want to load? ");
                string file = Console.ReadLine();
                string[] filedata = System.IO.File.ReadAllLines(file);

                //puts all of the data from the string into usable journal entry 
                j._entries.Clear();
                foreach (string line in filedata)
                {
                    string[] parts = line.Split("|");

                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    //Enters the data into the entry class
                    Entry entry = new Entry();
                    entry._dateText = date;
                    entry._programPrompt = prompt;
                    entry._userResponse = response;

                    //Saves the entry data as a list in the journal entry
                    j._entries.Add(entry);
                }
            }
            //This is the Display Journal Entry Option
            else if (choice == 4)
            {
                j.displayJournal();

            }
            //This is the Quit Option
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for your journal entry. Please come back tomorrow!");
            }
            //This is if they enter a wrong option.
            else
            {
                Console.WriteLine("Please enter a valid response!");
            }
        }
    }
    //Writes out a menu to the console
    static void DisplayMenu()
    {   
        Console.WriteLine();
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Write Prompt");
        Console.WriteLine("2. Save Journal Entry");
        Console.WriteLine("3. Load Journal Entry");
        Console.WriteLine("4. Display Journal Entry");
        Console.WriteLine("5. Quit");
        Console.WriteLine("------------------------------------");
        Console.Write("Your Number Selection: ");
    }

    /*A list of prompts that will be randomly picked and given to the user
    All prompts have been generated by AI, because i'm too lazy to come up
    with so many*/
    static string PickPrompt()
    {
        List<string> prompts = new List<string>()
        {
            // Reflections on the Day
            "What is one thing you are grateful for today?",
            "What was the highlight of your day?",
            "What was the most challenging part of your day and how did you handle it?",
            "What did you learn today?",
            "What is one small act of kindness you witnessed or performed today?",
            "How are you feeling physically, mentally, and emotionally right now?",
            "What is one thing you could have done differently today?",
            "What are your intentions for tomorrow?",
            "Who did you connect with today and how did that interaction make you feel?",
            "What brought you joy or made you smile today?",

            // Self-Reflection and Personal Growth
            "What is a goal you are currently working towards and what steps did you take today?",
            "What is a belief you hold about yourself? Is it serving you?",
            "What is something you want to improve about yourself?",
            "What are your core values and how did you live them out today?",
            "What is a fear you are facing and how are you addressing it?",
            "What is a skill you would like to learn or develop?",
            "What is a book, podcast, or article that resonated with you recently and why?",
            "What is a piece of advice you would give to your younger self?",
            "What is something you are proud of accomplishing, no matter how small?",
            "How are you practicing self-care?",

            // Thoughts and Feelings
            "What is on your mind right now?",
            "What emotions are you currently experiencing and why?",
            "What thoughts are you having about the future?",
            "What are you worried about?",
            "What are you excited about?",
            "What is something that is inspiring you?",
            "What is a memory that came to mind today?",
            "What are you dreaming about lately?",
            "If you could talk to your feelings, what would they say?",
            "What is something you need to let go of?",

            // Creativity and Imagination
            "If you could have any superpower, what would it be and how would you use it?",
            "Imagine your perfect day. What would it look like?",
            "If you could travel anywhere in the world right now, where would you go and why?",
            "What is a story idea that comes to mind?",
            "If your life was a movie, what genre would it be and what would the title be?",
            "What is a problem in the world you wish you could solve?",
            "If you could have dinner with any three people (living or deceased), who would they be and why?",
            "What is a creative project you would like to start?",
            "What is a question you have for the universe?",
            "Describe a place you find peaceful.",

            // Gratitude and Appreciation
            "Who is someone you are grateful for and why?",
            "What is a simple pleasure you appreciate?",
            "What is an opportunity you are thankful for?",
            "What is a talent or skill you appreciate having?",
            "What is something in nature that you find beautiful?",
            "What is a piece of music that makes you feel good?",
            "What is a comfort item you appreciate?",
            "What is a lesson you learned from someone else?",
            "What is a positive change you've noticed in your life?",
            "What is something you appreciate about your current circumstances?",

            // Looking Ahead
            "What are your top three priorities for the week?",
            "What is one small step you can take towards a bigger goal?",
            "What are you looking forward to?",
            "What challenges do you anticipate and how can you prepare?",
            "What kind of day do you want to have tomorrow?",
            "What is a new habit you would like to cultivate?",
            "What is something you want to learn more about?",
            "What is a way you can step outside of your comfort zone?",
            "What is a way you can be kinder to yourself?",
            "What is a way you can connect more deeply with others?"
        };

        //Chooses one of the random responses.
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        return prompts[randomIndex];

    }
}

//Class of one single journal entry and display journal entry
public class Entry
{
    public string _dateText;
    public string _programPrompt;
    public string _userResponse;
    
    public void DisplayEntry()
    {
        Console.WriteLine($"{_dateText}\nPrompt: {_programPrompt}\nYour Response: {_userResponse}");
    }
}

//Saves all journal entries into one list that can be accessed later for different things
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void displayJournal()
    {
        Console.WriteLine("--------Journal Entries--------");
        foreach (Entry e in _entries)
        {
            e.DisplayEntry();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}

//Lets you edit a string and then resave what you edited.
public class EditString
{
    public static string StringEditor(string UserResponse)
    {
        StringBuilder currentText = new StringBuilder(UserResponse);
        int cursorPosition = currentText.Length;

        Console.CursorVisible = true;

        Console.Clear();

        while (true)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(currentText.ToString().PadRight(Console.WindowWidth - 1));

            Console.SetCursorPosition(cursorPosition, 0);

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    Console.CursorVisible = false;
                    Console.WriteLine();
                    return currentText.ToString();

                case ConsoleKey.LeftArrow:
                    if (cursorPosition > 0)
                    {
                        cursorPosition--;
                    }
                    break;

                case ConsoleKey.RightArrow:
                    if (cursorPosition < currentText.Length)
                    {
                        cursorPosition++;
                    }
                    break;

                case ConsoleKey.Backspace:
                    if (cursorPosition > 0)
                    {
                        currentText.Remove(cursorPosition - 1, 1);
                        cursorPosition--;
                    }
                    break;

                case ConsoleKey.Delete:
                    if (cursorPosition < currentText.Length)
                    {
                        currentText.Remove(cursorPosition, 1);
                    }
                    break;

                default:
                    if (!char.IsControl(keyInfo.KeyChar))
                    {
                        currentText.Insert(cursorPosition, keyInfo.KeyChar);
                        cursorPosition++;
                    }
                    break;
            }
        }
    }
}