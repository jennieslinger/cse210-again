using System;
using System.Data;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine("Welcome Warrior. What is your name?");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Warrior {playerName}, get ready to fight the good fight and manage your goals.");
        Thread.Sleep(7000);

        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("\nEarn heart points now by managing your goals.");

            Console.WriteLine("\nSelect a choice from the menu: ");
            Console.WriteLine("    1. Create a new goal");
            Console.WriteLine("    2. See a list of your goals");
            Console.WriteLine("    3. Save your goals");
            Console.WriteLine("    4. Load your goals");
            Console.WriteLine("    5. Record a new event");
            Console.WriteLine("    6. Quit the program");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalNames();
                    Console.WriteLine("");
                    ListGoalDetails();
                    Console.WriteLine("\nPress any key to continue. ");
                    Console.ReadKey();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine($"Roger that. Maintain contact with your commanding officer.\n Godspeed, Warrior {playerName}. Over and out. ");
                    return;
                default:
                    Console.WriteLine("Go again. Select an option from the menu. ");
                    Thread.Sleep(2000);
                    Console.Clear();
                    break;
            }
        }

    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Warrior, you have {_score} heart points!");
    }

    private void ListGoalNames()
    {
        Console.WriteLine("List of goals: ");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
        }
        else
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine($">> {goal._name}");
            }
            Console.WriteLine();
        }
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("Goal details: ");

        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet.");
        }
        else
        {
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
            Console.WriteLine();
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Select the type of goal: ");
        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");

        string type = Console.ReadLine();

        Console.WriteLine("Enter the name of your goal: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the description of your goal: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the number of heart points for completing the goal: ");
        int points = 0;
        while (!int.TryParse(Console.ReadLine(), out points))
        {
            Console.WriteLine("Go again. Enter a number.");
        }

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.WriteLine("Enter the target amount: ");
                int target = 0;
                while (!int.TryParse(Console.ReadLine(), out target))
                {
                    Console.WriteLine("Go again. Enter a number.");
                }
                Console.WriteLine("Enter the bonus points: ");
                int bonus = 0;
                while (!int.TryParse(Console.ReadLine(), out bonus))
                {
                    Console.WriteLine("Go again. Enter a number.");
                }
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Go again. Select the type of goal you want to create. ");
                return;
        }
        Console.WriteLine($"Goal '{name}' added succefully! ");
        Thread.Sleep(2000);
    }

    private void RecordEvent()
    {
        Console.WriteLine("Enter the name of your goal event: ");
        string name = Console.ReadLine();

        Goal goal = _goals.Find(g => g._name == name);

        if (goal != null)
        {
            int pointsEarned = goal.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Event recorded for goal name: {name}");
            Console.WriteLine($"You earned {pointsEarned} heart points!");
            Thread.Sleep(1500);
        }
        else
        {
            Console.WriteLine($"Negative. Goal '{name}' not found.");
        }
        Thread.Sleep(2000);
    }

    private void SaveGoals()
    {
        Console.WriteLine("Enter the filename to save your goals.");
        string filename = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Goal goal in _goals)
                {
                    string data = goal.GetStringRepresentation();
                    writer.WriteLine(data);
                }
            }
            Console.WriteLine($"10-4. Goals saved to '{filename}'.");
            Thread.Sleep(2000);
        }
        catch (Exception)
        {
            Console.WriteLine($"Error saving goals.");
        }
        Thread.Sleep(2000);
    }

    private void LoadGoals()
    {
        Console.WriteLine("Enter the filename to load goals from: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(':');

                    if (parts.Length >= 4)
                    {
                        string type = parts[0].Trim();
                        string name = parts[1].Trim();
                        string description = parts[2].Trim();
                        int points;

                        if (int.TryParse(parts[3].Trim(), out points))
                        {
                            int target = 0;
                            int bonus = 0;

                            if (type == "Checklist" && parts.Length >= 6)
                            {
                                int.TryParse(parts[4].Trim(), out target);
                                int.TryParse(parts[5].Trim(), out bonus);
                            }

                            switch (type)
                            {
                                case "Simple":
                                    _goals.Add(new SimpleGoal(name, description, points));
                                    break;
                                case "Eternal":
                                    _goals.Add(new EternalGoal(name, description, points));
                                    break;
                                case "Checklist":
                                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Invalid value for goal '{name}'");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Negavitve. Incomplete data for goal.");
                    }
                }
            }
            Console.WriteLine($"10-4. Goals loaded from '{filename}'.");

            ListGoalNames();
            Console.WriteLine("");
            ListGoalDetails();
        }
        catch (Exception)
        {
            Console.WriteLine($"Error loading goals from '{filename}'.");
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}