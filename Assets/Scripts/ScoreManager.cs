using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public Text highscore;

	void OnEnable(){
		Debug.Log ("Sceneloaded");
		Debug.Log (PlayerPrefs.GetInt ("Highscore"));
		highscore.text = "Highscore: " + PlayerPrefs.GetInt ("Highscore");
		
	}


}
