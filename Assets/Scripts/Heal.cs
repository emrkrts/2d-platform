using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameControl.health += 1;
        PlayerPrefs.SetInt("health", GameControl.health);
    }
}
