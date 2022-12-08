using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public Vector3 propellerVector;

    // Start is called before the first frame update
    void Start()
    {
        propellerVector = new(0, 0, 11);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Rotate(propellerVector);
    }
}
