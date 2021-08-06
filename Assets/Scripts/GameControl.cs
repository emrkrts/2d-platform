using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver;
    public static int health;
    public static int isActive ;


    void Start()
    {
        health = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);

        
        if (PlayerPrefs.HasKey("health"))
        {
            health = PlayerPrefs.GetInt("health");
        }

        if (PlayerPrefs.HasKey("isActive"))
        {
            isActive = PlayerPrefs.GetInt("isActive");
        }
    }

    void Update()   
    {
        if (health > 3)
        {
            health = 3;
        }
        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                isActive++;
                if (isActive == 1)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                isActive = 2;
                break;
            case 1:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(true);                
                if (isActive <= 3)
                {
                    SceneManager.LoadScene(1);
                }
                isActive += 1;
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                PlayerPrefs.DeleteKey("health");
                PlayerPrefs.DeleteKey("isActive");

                Time.timeScale = 0;
                break;
        }
    }
}
