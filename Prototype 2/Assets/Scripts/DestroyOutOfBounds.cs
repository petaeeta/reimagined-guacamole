using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private readonly float topBound = 50;
    private readonly float botBound = -10;

    // Start is called before the first frame update.
    void Start()
    {

    }

    // Update is called once per frame.
    void Update()
    {
        // Destroys an object that passes top bound, ends the game if an object(an animal) gets past bottom bound.
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < botBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
