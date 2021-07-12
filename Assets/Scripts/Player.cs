using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Code heavily inspired by Blackthornprod from YouTube
// https://www.youtube.com/watch?v=RZTpDxgrDkQ

public class Player : MonoBehaviour
{
    public float speed;
    public int health = 3;
    public Animator animator;
    public GameObject Life1, Life2, Life3;

    private Rigidbody2D rb;
    private Vector2 moveVelocity;

    void Start()
    {
        // Sets up all the variables
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        animator.SetBool("Left", false);
        animator.SetBool("Right", false);
        animator.SetBool("Up", false);
        animator.SetBool("Down", false);
        Life1.gameObject.SetActive(true);
        Life2.gameObject.SetActive(true);
        Life3.gameObject.SetActive(true);

    }

    void Update()
    {
        
        // If the player presses any of these buttons, they set on/off the booleans so that the animations are aware
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Left", true);
        }
        else
        {
            animator.SetBool("Left", false);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Right", true);
        }
        else
        {
            animator.SetBool("Right", false);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Up", true);
        }
        else
        {
            animator.SetBool("Up", false);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Down", true);
        }
        else
        {
            animator.SetBool("Down", false);
        }

        if (health == 2)
        {
            Life3.gameObject.SetActive(false);
        }

        if (health == 1)
        {
            Life2.gameObject.SetActive(false);
        }

        if (health <= 0)
        {
            SceneManager.LoadScene(2);
        }

        // Movement
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    void FixedUpdate ()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
}
