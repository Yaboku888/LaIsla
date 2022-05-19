using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    [Header("movimiento de personaje")]
    public float speedMovement;
    //acceso-//tipo de variable //nombre
    public Vector3 direccion;
    public CharacterController controller;

    [Header("Movimiento de la camará")]
    public Vector2 MouseMovement;
    public Camera playerCamera;
    public float rotationcameraX;




    //movimiento del personaje  
    private void Update()
    {
        rotationcameraX -= MouseMovement.y;
        MouseMovement.x = Input.GetAxis("Mouse X");
        MouseMovement.y = Input.GetAxis("Mouse Y");
        playerCamera.transform.localRotation = Quaternion.Euler(rotationcameraX, 0, 0);
        
        //vector 2= (h-v)
        //Direccion en la que se mueve el personaje

        direccion.x = Input.GetAxis("Horizontal");
        direccion.z = Input.GetAxis("Vertical");
        controller.Move(direccion * Time.deltaTime * speedMovement);



        /*if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Se esta presionando el boton del mouse");
        }
        if (Input.GetAxis("Horizontal") != 0)
        {
            Debug.Log(Input.GetAxis("Horizontal"));
        }
        if (Input.GetAxis("Vertical")!=0)
        {
            Debug.Log(Input.GetAxis("Vertical"));
        }*/
    }

}
