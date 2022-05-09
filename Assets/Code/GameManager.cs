using System;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
	public static GameManager Instance { get; private set; }

	[SerializeField] private TextMeshProUGUI textScore;

	public int Score
	{
		get => _score;
		set
		{
			if (value > _score)
			{
				_score = value;
				textScore.SetText(_score.ToString());
			}
		}
	}

	private int _score;

	private void Awake()
	{
		Instance = this;
	}

	public void GameOver()
	{
		Debug.Log("Game Over");
		Time.timeScale = 0;
	}
}