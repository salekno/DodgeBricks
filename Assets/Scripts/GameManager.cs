using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Text pointsText;

	public static int points;

	void Start(){
		points = 0;
		InvokeRepeating ("PointsAdd", 5.5f, 1.0f);
	}

	void PointsAdd(){
		points++;
		pointsText.text = "" + points;
	}


}
