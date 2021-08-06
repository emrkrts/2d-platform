using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        GameControl.health -= 1;
        PlayerPrefs.SetInt("health", GameControl.health);
    }    
}
