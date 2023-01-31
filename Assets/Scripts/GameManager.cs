using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverPanel;
    [SerializeField] private GameObject mainMenuPanel;
    public void Start() {
        Time.timeScale = 0;
        gameScore(0);
        if (PlayerPrefs.GetInt("playerLevel") == null) {
            PlayerPrefs.SetInt("playerLevel",1);
            Debug.Log(PlayerPrefs.GetInt("playerLevel"));

        }
        gameOverPanel.SetActive(false);
      
    }
    public void gameScore(int ringScore) {
        score += ringScore;
        scoreText.text = score.ToString();
    }
    public void playGame() {
        Time.timeScale =1;
        gameOverPanel.SetActive(false);
        mainMenuPanel.SetActive(false);
    }
    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    }
    public void nextLevel() {
        PlayerPrefs.SetInt("playerLevel", PlayerPrefs.GetInt("playerLevel")+1);
        SceneManager.LoadScene(PlayerPrefs.GetInt("playerLevel"));
    }
    public void setPanel(string panelName,bool active) {
        if (panelName=="gameOverPanel") {
            gameOverPanel.SetActive(active);
        }
        else if (panelName=="mainMenuPanel") {
            mainMenuPanel.SetActive(active);

        }
        else {
            Debug.LogError("Yanlış değer girdiniz");
        }
    }
}
