using UnityEngine;
using UnityEngine.UI;


public class scoreCounter : MonoBehaviour
{

	public int totalScore;
	public Text scoreText;
	public Text totalScoreText;

    void Update()
    {
		scoreText.text = totalScore.ToString();
		totalScoreText.text = totalScore.ToString();
	}
}
