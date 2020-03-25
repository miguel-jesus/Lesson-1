using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 25.0f; // velocidad de giro
    private float horizontalInput;
    private float forwardInput;


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");//key a d lados
        forwardInput = Input.GetAxis("Vertical");//keys w s adelante atras

        //move the vehicle forward
        //forward = adelante, si ponemos 0,0,1 le indicamos que se mueva en la z hacia adelante
        //hacemos que vaya mas despacio con el deltaTime 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //en lugar de girar de lado a lado ahora rotaremos ,es decir,un movimiento de giro mas realista
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        //Allow the vehicle to move left/right
       // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
