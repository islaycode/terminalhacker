using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string[] level2Pass = { "gta", "red dead", "max payne" };
    string[] level1Pass = { "creed", "rainbow six"};
    string[] level3Pass = { "uncharted","last of us" };
    enum Screen{MainMenu,Password,Win }
    Screen currentScreen;
    
    // Game state
    int level;// member variable
    string password;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Hello Nikhil");
    }
    void ShowMainMenu(string greet)
    {
        currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine(greet);
        Terminal.WriteLine("Welcome to Hacker's portal,What would you like to Hack tody?");
        Terminal.WriteLine("Press 1 to Hack Ubisoft.");
        Terminal.WriteLine("Press 2 to Hack Rockstar Games.");
        Terminal.WriteLine("Press 3 to Hack Naught Dog Games.");
        Terminal.WriteLine("Type Quit to Exit the Game!");
        Terminal.WriteLine("Type Menu to Enter the Menu again!");
        Terminal.WriteLine("Type Clear to clear the your selection!");
        Terminal.WriteLine("Please Enter your selection: ");
    }
    void OnUserInput(string input)
    {
       
        if (input == "menu")
        {
            ShowMainMenu("Welcome back to the Main Menu!");

        }
        else if(currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
        else if (input == "quit" || input =="close")
        {
            Application.Quit();
        }

    }

    void RunMainMenu(string input)
    {
       
        if (input == "1")
           {
            print("User has selected option 1");
            Terminal.WriteLine("You've choose to Hack Ubisoft, Great!");
            level = 1;
            password = level1Pass[0];
            AskForPassword();
        }
        else if (input == "2")
        {
            print("User has selected option 2");
            Terminal.WriteLine("You've choose to Hack Rockstar Games, Great!");
            level = 2;
            password = level2Pass[2];
            AskForPassword();
        }
        else if (input == "3")
        {
            print("User has selected option 3");
            Terminal.WriteLine("You've choose to Hack Naughty Dog Games, Great!");
            level = 3;
            password = level3Pass[1];
            AskForPassword();
        }
        else if (input == "clear")
        {
            Terminal.ClearScreen();
            ShowMainMenu("Welcome back to the Main Menu!");

        }
        else if(input == "exit")
        {
            ShowMainMenu("Welcome back to Main menu!");
        }
        else
        {
            Terminal.WriteLine("Invalid option please Try agin!");
        }
    }

    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        Terminal.WriteLine("You've selected level = " + level);
        Terminal.WriteLine("Enter Password to Hack, Hint:"+password.Anagram());
        
    }
    void CheckPassword(string input)
    {
        if(input == password)
        {
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("Ubisoft is Hacked!");
                Terminal.WriteLine(@"
         _______
        /      / /
       /      / /
      /Hacked/ /
     /______/ / 
    (______( /
    
    Congrats, You Hacked Ubitsoft !!!!
    
");
                break;
            case 2:
                Terminal.WriteLine("Rockstar is Hacked!");
                Terminal.WriteLine(@"
         _______
        /      / /
       /      / /
      /Hacked/ /
     /______/ / 
    (______( /
    
    Congrats, You Hacked Rockstar!!!!
    
");
                break;

            case 3:
                Terminal.WriteLine("Naughty Dog is Hacked!");
                Terminal.WriteLine(@"
         _______
        /      / /
       /      / /
      /Hacked/ /
     /______/ / 
    (______( /
    
    Congrats, You Hacked Naughty Dog!!!!
    
");
                break;

        }
        
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
}
