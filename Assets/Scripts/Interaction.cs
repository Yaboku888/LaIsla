using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public Playerstadistics playerstadistics;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "puerta" && playerstadistics.batterycount>=3)
        {

         other.GetComponentInParent<Puerta>().OnOpenDoor();
        }
        if (other.tag == "battery")
        {

            other.GetComponentInParent<Battery>().desaparecer();
            Debug.Log("la bateria se recogió");
            playerstadistics.batterycount++;
        }
       

    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}

