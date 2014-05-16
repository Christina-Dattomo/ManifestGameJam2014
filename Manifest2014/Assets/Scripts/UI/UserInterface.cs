using UnityEngine;
using System.Collections;

public class UserInterface : MonoBehaviour {
	public GUISkin customGUI;
	private bool DisplayLose = false;
	private bool DisplayStart = false;
	
	void Start () 
	{	
		switch (Application.loadedLevelName)
		{
		case "LoseScreen":	
			DisplayLose = true;
			break;
		case "StartScreen":
			DisplayStart = true;
			break;
		}
	}
	
	void OnGUI()
	{
		GUI.skin = customGUI;	
		if (DisplayLose)
			loseScreen ();
		if (DisplayStart)
			startScreen ();
	}
	
	void startScreen()
	{
		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height /2 + 100, 200, 100), "Start!"))
			Application.LoadLevel("LevelOne");
	}
	
	void loseScreen()
	{
		GUI.Label(new Rect (Screen.width / 2 - 100, Screen.height /2 - 75, 500, 100), "You Lose!");
		if (GUI.Button (new Rect (Screen.width / 2 - 100, Screen.height /2, 200, 100), "Play Again?"))
			Application.LoadLevel ("StartScreen");
	}
	
}
