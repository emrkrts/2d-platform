using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharacterControl : MonoBehaviour
{
    Rigidbody2D rgb;
    Vector3 velocity;
    public Animator animator;

    float speedAmount = 5f;
    float jumpAmount = 8f;
    bool alive;

    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        alive = true;
    }
    
    void Update()
    {
        velocity = new Vector3(Input.GetAxisRaw("Horizontal"), 0f); 
        transform.position += velocity * speedAmount * Time.deltaTime;
        animator.SetFloat("speed",Mathf.Abs(Input.GetAxisRaw("Horizontal")));

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rgb.velocity.y,0))
        {
            rgb.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
        }

        if (animator.GetBool("IsJumping") && Mathf.Approximately(rgb.velocity.y, 0))
        {
           animator.SetBool("IsJumping", false);
        }

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coins"))
        {
            Destroy(other.gameObject);
        }
    }
}
