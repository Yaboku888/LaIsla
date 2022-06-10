using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    [Header("movimiento de personaje")]
    public float speedMovement;
    //acceso-//tipo de variable //nombre

    public Vector3 direccion;
    public CharacterController controller;

   
    
    /* [Header("Movimiento de la camará")]
    public Vector2 MouseMovement;
    public Camera playerCamera;
    public float rotationcameraX;
    public float rotationcameraY;
    public float rotationplayerY;
    */

    [Header("Salto Del personaje")]
    public float JumpHeight;
    public Vector3 movimientoY;
    public float gravity = -9.8f;
    public float rotationY;


    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Move (float Vertical, float Horizontal)
    {
        direccion.x = Horizontal;
        direccion.z = Vertical;
        direccion = transform.TransformDirection(direccion);
        controller.Move(direccion * Time.deltaTime * speedMovement);

    }
    
    public void Rotation(float RotationValue)
    {
        rotationY += RotationValue; 
        controller.transform.localRotation = Quaternion.Euler(0, rotationY, 0);


    }

    private void Update()
    {
        /* if (rotationcameraX > 40 )
        {
            rotationcameraX = 40;

        }
        if (rotationcameraX<-40)
        {
            rotationcameraX = -40; 
        }*/
   
        //movmiento del mouse
        //MouseMovement.x = Input.GetAxis("Mouse X");
        //MouseMovement.y = Input.GetAxis("Mouse Y");

        //movimiento del personaje 
        direccion.x = Input.GetAxis("Horizontal");
        direccion.z = Input.GetAxis("Vertical");
 
        //transformar la direccion de coordenadas del jugador
        direccion = transform.TransformDirection(direccion);
        
        //velocidad del movimiento
        controller.Move(direccion * Time.deltaTime * speedMovement);
        
        //movimiento de la camara
        //rotationcameraX -= MouseMovement.y;
        //rotationplayerY += MouseMovement.x;
       
        
         //Rotacion limitada
        //rotationcameraX = Mathf.Clamp(rotationcameraX, -40, 40);
        
        //rotar la camara del personaje en base a el movimiento acumulado
        //playerCamera.transform.localRotation = Quaternion.Euler(rotationcameraX,0, 0);
        
        //rotar el pesonaje en base al movimiento acumulado
        //controller.transform.rotation = Quaternion.Euler(0, rotationplayerY, 0);

        //calcular gravedad de frame
        movimientoY.y += gravity *2f * Time.deltaTime;
       
       //mover el personaje en "Y" en base a la gravedad calculada
        controller.Move(movimientoY * Time.deltaTime);

        //si esta tocando el suelo y el movimiento en y es negativo resetear la gravedad
        if (controller.isGrounded && movimientoY.y < 0)
        {
            movimientoY.y = -2f;
        }

        //si el personaje esta tocando el suelo y al presionar la tecla, calcular el salto del personaje

        if (controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            
            movimientoY.y = Mathf.Sqrt(JumpHeight * -2f * gravity);
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
