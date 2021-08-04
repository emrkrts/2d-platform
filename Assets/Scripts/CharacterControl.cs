using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControl : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;

    float speedAmount = 5f;
    float jumpAmount = 8f;

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0f);
        transform.position += velocity * speedAmount * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y,0))
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
        }
    }
}
