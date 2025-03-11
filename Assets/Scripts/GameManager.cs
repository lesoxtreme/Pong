using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public int playerScore = 0;
	public int enemyScore = 0;
	public TextMeshProUGUI textPointsPlayer;
	public TextMeshProUGUI textPointsEnemy;
	public BallController ballController;
	  // No script do GameManager
	public Transform playerPaddle;
	public Transform enemyPaddle;
	
	// ...
	public GameObject ScreenEndGame;
	void Start()
	{
		ResetGame();
	}
	public void ResetGame()
	{
		ballController.ResetBall();
		// Define as posições iniciais das raquetes
		playerPaddle.position = new Vector3(-7f, 0f, 0f);
		enemyPaddle.position = new Vector3(7f, 0f, 0f);
		// ...
		playerScore = 0;
		enemyScore = 0;
		textPointsEnemy.text = enemyScore.ToString();
		textPointsPlayer.text = playerScore.ToString();

		ScreenEndGame.SetActive(false);
	}
	public void ScorePlayer()
		{
			playerScore++;
			textPointsPlayer.text = playerScore.ToString();
			CheckWin();
		}
	public void ScoreEnemy()
		{
			enemyScore++;
			textPointsEnemy.text = enemyScore.ToString();
			CheckWin();
		}
	public int winPoints;
	public void CheckWin()
	{
		if (enemyScore >= winPoints || playerScore >= winPoints)
		{
			//ResetGame();
			EndGame();
		}
	}
	public void EndGame()
		{
			ScreenEndGame.SetActive(true);
			string winner = SaveController.Instance.GetName(playerScore > enemyScore);
			textEndGame.text = "Victory "+winner;
			SaveController.Instance.SaveWinner(winner);
			Invoke("LoadMenu", 2f);
		}
	private void LoadMenu()
		{
		SceneManager.LoadScene("Menu");
		}
	public TextMeshProUGUI textEndGame;
		
	
}
