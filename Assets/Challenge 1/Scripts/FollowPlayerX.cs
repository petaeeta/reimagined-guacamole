using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;
    public Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        offset = new(30, 3, 10);
        transform.Rotate(new Vector3(0, -90, 0));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = plane.transform.position + offset;
    }
}
