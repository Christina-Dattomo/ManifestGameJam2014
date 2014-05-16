using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	public GUISkin customGUI;
	public int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void addScore(){
		score++;
	}

	void OnGUI()
	{
		GUI.skin = customGUI;
		GUI.Label(new Rect (Screen.width / 2, 10, 100, 100), ""+score+"");
	}	

}
