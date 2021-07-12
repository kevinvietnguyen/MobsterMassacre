using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code heavily inspired by Blackthornprod from YouTube
// https://www.youtube.com/watch?v=RZTpDxgrDkQ

public class Enemy : MonoBehaviour
{
    public float speed;
    private Transform playerPos;
    private Player player;

    void Start()
    {
        // Gets the player object and its position so we can work with it later
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        // Makes the enenmy always move towards the Player
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            // When it hits the player, the player loses health and the enemy dissapears
            player.health--;
            Debug.Log(player.health);
            Destroy(gameObject);
        }

        if(other.CompareTag("Projectile"))
        {
            // When it hits the projectile, the enemy and projectile dissapears
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
