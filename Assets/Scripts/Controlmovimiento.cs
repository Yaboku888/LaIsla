using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Player))]
public class Controlmovimiento : MonoBehaviour
{
    [Header("camara")]
    public Vector2 mouse;
    public Camera playercamera;
    public float rotationX, sensibilidad;
   // public float rotationY;
    //
    [Header("llamar el script")]
    public Player desplazo;

    // Update is called once per frame
    private void Update()
    {
        desplazo.Move(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"));
        desplazo.Rotation(Input.GetAxis("Mouse X"));
        mouse = new Vector2(Input.GetAxis("Mouse X") * sensibilidad, Input.GetAxis("Mouse Y") * sensibilidad);
        rotationX -= mouse.y;
        //rotationY += mouse.x;

        playercamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        //controller.transform.localRotation = Quaternion.Euler(0, rotationY, 0);

        rotationX = Mathf.Clamp(rotationX, -45, 45);
    }
}
