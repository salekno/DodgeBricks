using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;
	public Text gameOverText, highscoreText, totalDistanceText;
	public WaveManager waveManager;
	public GameManager gameManager;
	public bool gameOver;



	void Start(){
	}

	void OnCollisionEnter(Collision other){
		if (other.collider.tag == "Floor")
			return;

		if (other.collider.tag == "Obstacle" && !gameOver){
			GameOver ();
		}		
	}

	public void GameOver(){

		gameOver = true;
		gameOverText.enabled = true;
		totalDistanceText.enabled = true;
		PlayerPrefs.SetInt ("TotalDistance", PlayerPrefs.GetInt ("TotalDistance") + GameManager.points);
		totalDistanceText.text = "Total " + PlayerPrefs.GetInt ("TotalDistance");
		waveManager.CancelInvoke ();
		movement.enabled = false;
		gameManager.CancelInvoke ();
		if(GameManager.points > PlayerPrefs.GetInt ("Highscore"))
			PlayerPrefs.SetInt ("Highscore", GameManager.points);

		highscoreText.text = "Best " + PlayerPrefs.GetInt ("Highscore");
		
		Time.timeScale = 0.3F;
		Time.fixedDeltaTime = 0.01F * Time.timeScale;


	}

	void Update(){
		if(gameOver){
			highscoreText.color = Color.Lerp (highscoreText.color, gameOverText.color, 10f * Time.deltaTime);
			if (Input.GetMouseButtonUp (0)) {
				Time.timeScale = 1F;
				Time.fixedDeltaTime = 0.01F * Time.timeScale;
				gameOver = false;
				SceneManager.LoadScene ("Main");
			}
		}



	}
}
