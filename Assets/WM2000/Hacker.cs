using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    // game state
    // will appear in the dbug mode of unity around the script
    int level;
    enum Screen { MainMenu, Password, Win };
    Screen currentScreen;

    // Use this for initialization
    void Start() {
        //var greeting = "Hello Donny";
        ShowMainMenu();
        
    }


	void ShowMainMenu () {
        Screen currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("1. Library.");
        Terminal.WriteLine("2. Police.");
        Terminal.WriteLine("3. CIA.");
        Terminal.WriteLine("4. OMG, what I doing, QUIT QUIT");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Key in a value from above");
        Terminal.WriteLine("and press enter to begin");

    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            currentScreen = Screen.MainMenu;
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);    
        }

    }

    private void RunMainMenu(string input)
    {
        switch (input)
        {
            case "007":
                Terminal.WriteLine("Try again mr bond");
                break;
            case "1":
                level = 1;
                StartGame();
                break;
            case "2":
                level = 2;
                StartGame();
                break;
            case "3":
                level = 3;
                StartGame();
                break;
            case "4":
                Terminal.WriteLine("You chose option " + input);
                break;
            default:
                Terminal.WriteLine("Choose a valid option");
                break;
        }
    }

    private void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have chosen level " + level);
    }
}
