using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string levelName){
		Debug.Log("Level Load Requested for: " + levelName);
		Application.LoadLevel(levelName); //Loads a level
	}
	
	public void QuitRequest(){
		Debug.Log("Quit Requested for Game");
	}
	
}
