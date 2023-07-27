using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    [SerializeField] private int playerScore;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private AudioSource ding;


    [ContextMenu("IncreaseScore")]
    public void AddScore(int scoreToAdd)
    {

        playerScore += scoreToAdd;
        scoreText.text = playerScore.ToString();
        ding.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void GameOver()
    {

        gameOver.SetActive(true);
    }

    public void StopGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
