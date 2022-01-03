using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {


	// Use this for initialization
	void Start () {

		ShowMainMenu ();

	}

	void ShowMainMenu () 
	{
		currentScreen = Screen.MainMenu; 
		Terminal.ClearScreen();
		Terminal.WriteLine("What if you could Hack a Cooperation?");
		Terminal.WriteLine("Press 1 for Nike");
		Terminal.WriteLine("Press 2 for Instagram");
		Terminal.WriteLine("Press 3 for Google");
		Terminal.WriteLine("Enter Your Selection: ");

	}

	//Game State
	int level;
	enum Screen {MainMenu, Password, Win };
	Screen currentScreen; 

	// this should only decide how to handle input, not actually do it
	void OnUserInput(string input)
	{
		if (input == "menu") 
		{ // we can always go direct to main menu

			ShowMainMenu ();
		} 
		else if (currentScreen == Screen.MainMenu)
		{
			RunMainMenu (input);
		}
	}
		
	void RunMainMenu (string input){
	    
		if (input == "1") {

			level = 1;
			StartGame ();

		} 
		else if (input == "2") {

			level = 2;
			StartGame ();

		}

		else if (input == "007")
		{
			Terminal.WriteLine("Please choose a level Mr. Bond!");
		}
		else
		{
			Terminal.WriteLine("Please choose a valid level");
		}
	}


	void StartGame ()
   {
		currentScreen = Screen.Password;
		Terminal.WriteLine ("You have chosen level " + level);
		Terminal.WriteLine ("Please enter your Password: ");

	}
}