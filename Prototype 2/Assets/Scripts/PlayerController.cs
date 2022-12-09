using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;
    public float xRange = 10;
    public GameObject projectilePrefab;

    private Vector3 negativeBound;
    private Vector3 positiveBound;


    // Start is called before the first frame update
    void Start()
    {
        // Initialize x-bounds for the game
        negativeBound = new Vector3(-xRange, transform.position.y, transform.position.z);
        positiveBound = new Vector3(xRange, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        // If player position is out of bounds, snap player position back in bounds.
        if (transform.position.x < -xRange)
        {
            transform.position = negativeBound;
        }
        else if (transform.position.x > xRange)
        {
            transform.position = positiveBound;
        }

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
