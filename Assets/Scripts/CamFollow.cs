using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform karakter;
    public float x = 5.5f;

    void Start()
    {
        karakter = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    void Update()
    {
        transform.position = new Vector3(karakter.position.x+x, 0, -10);
    }
}
