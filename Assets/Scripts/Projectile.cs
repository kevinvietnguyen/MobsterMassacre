using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Vector2 target;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the target of the projectile (the area where the mouse is
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        // Ensures that the projectile move towards the target
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        // Ensures that the projectile dissapears after a certain distance away from the target
        if (Vector2.Distance(transform.position, target) < 0.2f)
        {
            Destroy(gameObject);
        }

    }
}
