using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
   // public Text scoreText;
    public TextMeshProUGUI scoreText;
    public void Start() {
        gameScore(0);
    }
    public void gameScore(int ringScore) {
        score += ringScore;
        scoreText.text = score.ToString();
    }

    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
