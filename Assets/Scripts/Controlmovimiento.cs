using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlmovimiento : MonoBehaviour
{
    [Header("camara")]
    public Vector2 mouse;
    public Camera playercamera;
    public float rotationX, sensibilidad;
    public float rotationY;
    public CharacterController controller;
    // Update is called once per frame
    private void Update()
    {
        mouse = new Vector2(Input.GetAxis("Mouse X") * sensibilidad, Input.GetAxisRaw("Mouse Y"));
        rotationX -= mouse.y;
        rotationY += mouse.x;

        playercamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
        controller.transform.localRotation = Quaternion.Euler(0, rotationY, 0);

        rotationX = Mathf.Clamp(rotationX, -45, 45);
    }
}
