using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Rigidbody2D rgb;

    public float speed;
    public Animator animator;

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime * 1;
    }

    public void SagaGit()
    {
        speed = 5f;
    }
    public void SolaGit()
    {
        speed = -5f;
    }
    public void Zıpla()
    {
        //rgb.AddForce(new Vector2(0, 3), ForceMode2D.Impulse);
        if (Mathf.Approximately(rgb.velocity.y, 0))
        {
            Debug.Log("İf içerisine girdi");
            rgb.AddForce(new Vector2(0, 8), ForceMode2D.Impulse);
        }
    }
    public void Dur()
    {
        speed = 0;
    }
}
