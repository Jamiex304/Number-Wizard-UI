using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;
	int min;
	int guess;
		
	int maxGuessesAllowed = 5;//Computer has 5 guesses at start
	public Text GuessText;
	public Text GuessesLeft;
	
	//Called for starting and restarting the game		
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		//Variables at start
		max = 1000;
		min = 1;
		NextGuess();
	}
	
	public void GuessHigher(){
		min = guess;
		NextGuess();
		//Show number of guesses
		maxGuessesAllowed = maxGuessesAllowed - 1;
		GuessesLeft.text = maxGuessesAllowed.ToString();
	}
	public void GuessLower(){
		max = guess;
		NextGuess();
		//Show number of guesses
		maxGuessesAllowed = maxGuessesAllowed - 1;
		GuessesLeft.text = maxGuessesAllowed.ToString();
	}
	
	void NextGuess () {
		guess = Random.Range(min, max+1);
		GuessText.text = guess.ToString();
		
		//Win condition for player
		if(maxGuessesAllowed <= 1){
			Application.LoadLevel("Win");//Calls Win Level
		}
	}
}
