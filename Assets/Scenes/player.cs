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
    public float rotationcameraY;
    public float rotationplayerY;
    public float gravity = 9.8f;

    [Header("Salto Del personaje")]
    public float JumpHeight;
    
   
    private void Update()
    {

      //movimiento del personaje 
        direccion.x = Input.GetAxis("Horizontal");
        direccion.z = Input.GetAxis("Vertical");
        direccion.y += gravity * Time.deltaTime;

        if (controller.isGrounded && direccion.y >0)
        {
            direccion.y = -2f;
        }

        direccion = transform.TransformDirection(direccion);
        controller.Move(direccion * Time.deltaTime * speedMovement);

        rotationcameraX -= MouseMovement.y;
        rotationplayerY += MouseMovement.x;
       

        /* if (rotationcameraX > 40 )
        {
            rotationcameraX = 40;

        }
        if (rotationcameraX<-40)
        {
            rotationcameraX = -40; 
        }*/

        
        //Rotacion limmitada
        rotationcameraX = Mathf.Clamp(rotationcameraX, -40, 40);

        //Rotacion
        MouseMovement.x = Input.GetAxis("Mouse X");
        MouseMovement.y = Input.GetAxis("Mouse Y");
        playerCamera.transform.localRotation = Quaternion.Euler(rotationcameraX,0, 0);
        controller.transform.rotation = Quaternion.Euler(0, rotationplayerY, 0);

            
        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            direccion.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
        }        
            
        
        
        
        
        //vector 2= (h-v)
        //Direccion en la que se mueve el personaje

        



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
