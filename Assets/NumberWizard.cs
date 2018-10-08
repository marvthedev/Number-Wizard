using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
        int maxGuess = 1000;
        int minGuess = 1;
        int playersGuess;


        Debug.Log("Welcome to Number Wizard, yo!");
        Debug.Log("Pick a number between " + minGuess + " and " + maxGuess);
        Debug.Log("The highest number you can guess is " + maxGuess);
        Debug.Log("The lowest number you can guess is " + minGuess);
        Debug.Log("Higher or lower than 500?");
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");


	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
            Debug.Log("Up Arrow key was released.");
	}
}
