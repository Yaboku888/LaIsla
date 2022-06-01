using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{

    public Playerstadistics playerstadistics;
    public Transform cameraPlayer;
    public Transform objetoVacio;
    public LayerMask lm;
    public GameObject OBJETO;

    private void Update()
    {
        Debug.DrawRay(cameraPlayer.position, cameraPlayer.forward, Color.blue);
        RaycastHit hit;
        
        if (Physics.Raycast(cameraPlayer.position, cameraPlayer.forward,  out hit,2f, lm))
        {
            if (Input.GetButtonDown("Agarrar"))
            {
                OBJETO.GetComponent<Rigidbody>().isKinematic = true;
                Debug.Log(hit.transform.name);
                hit.transform.parent = objetoVacio;
                hit.transform.localPosition = Vector3.zero;
                
            }   

            if (Input.GetButtonDown("Soltar"))
            {
                OBJETO.GetComponent<Rigidbody>().isKinematic = false;
                hit.transform.parent = null;
            }
        }
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

