using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX: MonoBehaviour
{
    private float turnSpeed = 20.0f;

    // Update is called once per frame
    void Update()
    {
         transform.Rotate(Vector3.forward, turnSpeed);
    }
}
