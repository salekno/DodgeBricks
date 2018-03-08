using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (this);
	}
	

	public void loadGame(){
		SceneManager.LoadScene ("Main");
	}

	public void loadMainMenu(){
		SceneManager.LoadScene ("MainMenu");
	}
}
