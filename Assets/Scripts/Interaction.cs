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
    public GameObject arma;
    public Transform weapon;

    private void Update()
    {

        if (objetoVacio.childCount > 0 && Input.GetButtonDown("Agarrar"))
        {
            OBJETO.GetComponentInChildren<Rigidbody>().isKinematic = false;
            objetoVacio.GetChild(0).transform.parent = null;
           // objetoVacio.GetComponentInChildren<Transform>().parent = null;
                
            }
   
          
        Debug.DrawRay(cameraPlayer.position, cameraPlayer.forward * 2, Color.blue);
       
        RaycastHit hit;
        if (Physics.Raycast(cameraPlayer.position, cameraPlayer.transform.forward,  out hit, 2f, lm))
        {
            if (Input.GetButtonDown("Agarrar"))
            {
                OBJETO.transform.GetComponent<Rigidbody>().isKinematic = true;
             
                hit.transform.parent = objetoVacio;
                hit.transform.localPosition = Vector3.zero;
                   //Debug.Log(hit.transform.name);
            }    
            
          

            
            {
               
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

        if (other.tag == "weapon")
        {
            arma.transform.parent = weapon;
            arma.transform.localPosition = Vector3.zero;              
        }
       

    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }
}

