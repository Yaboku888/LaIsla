using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

    public Playerstadistics playerstadistics;
    public Transform cameraPlayer;


    private void Update()
    {
        Debug.DrawRay(cameraPlayer.position, cameraPlayer.forward, Color.blue);
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "puerta" && playerstadistics.batterycount>=3)
        {

         other.GetComponentInParent<Puerta>().OnOpenDoor();
        }
        if (other.tag == "battery")
        {

            other.GetComponentInParent<Battery>().desaparecer();
            playerstadistics.batterycount++;

            Debug.Log("las baterias se recogieron");
        }


       

    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}

