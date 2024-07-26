using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
   public int playerscore; 
   public Text scoretext;
   public GameObject gameOverScreen;

    [ContextMenu ("tambah score")]
   public void addScore(int scoreToAdd)
   {
        playerscore = playerscore + scoreToAdd;
        scoretext.text = playerscore.ToString();
   }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }

}
