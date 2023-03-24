using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    //this makes projectiles disappear when they leave the player's view
    //otherwise, projectiles are still rendering, and will cause lag and shit

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound) {
            Debug.Log("You have been overrun. Game Over.");
            Destroy(gameObject);
        }

    }
}
