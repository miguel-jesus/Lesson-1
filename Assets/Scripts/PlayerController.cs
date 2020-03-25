using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //move the vehicle forward
        //forward = adelante, si ponemos 0,0,1 le indicamos que se mueva en la z hacia adelante
        //hacemos que vaya mas despacio con el deltaTime
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
