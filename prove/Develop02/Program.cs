using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Entry Program");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        int choice = 1;
        while(choice != 5)
        {
            DisplayMenu();
            string number = Console.ReadLine();
            choice = int.Parse(number);
            
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
                Console.WriteLine($"Your response is: {UserResponse}");
                bool response = true;

                while (response){
                    Console.WriteLine("Would you like to edit your response?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    string EditChoice = Console.ReadLine();
                    int Edit = int.Parse(EditChoice);
                    //This will be the option to edit the prompt.
                    if (Edit == 1)
                    {
                        response = false;
                    }
                    //This will be the option to save prompt to the entry class
                    else if (Edit == 2)
                    {
                        //Gets the current date
                        DateTime theCurrentTime = DateTime.Now;
                        string dateText = theCurrentTime.ToShortDateString();

                        Entry entry = new Entry();
                        entry._dateText = dateText;
                        entry._programPrompt = prompt;
                        entry._userResponse = UserResponse;

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

            }
            //This is the Load Journal Entry Option
            else if (choice == 3)
            {

            }
            //This is the Display Journal Entry Option
            else if (choice == 4)
            {

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
    static string PickPrompt()
    {
        List<string> prompts = new List<string>()
        {
            "What did I do today that I am proud of?",
            "What is your biggest fear, and how does it impact your behavior and decisions?",
            "What brings you joy?",
            "What was your favorite toy?",
            "What do you want to be when you grow up? Why?",
            "What are five things you would like to do before you are 20 years old?",
            "What is your dream job? Describe a typical work day at this job."
        };
        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        return prompts[randomIndex];

    }
}

public class Entry
{
    public string _dateText;
    public string _programPrompt;
    public string _userResponse;
    
    public void DisplayEntry()
    {
        Console.Write($"{_dateText}\nPrompt\n{_programPrompt}\nYour Response\n{_userResponse}");
    }
}