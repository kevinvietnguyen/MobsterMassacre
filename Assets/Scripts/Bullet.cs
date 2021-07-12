using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code heavily inspired by Blackthornprod from YouTube
// https://www.youtube.com/watch?v=RZTpDxgrDkQ

public class Bullet : MonoBehaviour
{
    public GameObject shot;
    private AudioSource gun;
    private Transform playerPos;

    // Start is called before the first frame update
    void Start()
    {
        playerPos = GetComponent<Transform>();
        gun = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var offset = new Vector3(0, 1, 0);

        // When the player clicks the mouse, it will shoot the bullet from the player's position
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(shot, playerPos.position, Quaternion.identity);
            gun.PlayOneShot(gun.clip);
        }
    }
}
