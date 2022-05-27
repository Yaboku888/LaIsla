using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public GameObject plataforma;
        //public GameObject boton;

    public Transform positionmin;
    public Transform positionmax;
    public float speedmovent;

    private void OnTriggerStay(Collider other)
    {
        if (other !=null)
        {
            MovePlataform();
            Debug.Log("El botón se esta presionando");
        }
    }

    private void MovePlataform()
    {
        plataforma.transform.Translate(Vector3.up * Time.deltaTime * speedmovent);
        
        


         if (plataforma.transform.position.y > positionmax.position.y && speedmovent > 0)
        {
            speedmovent = speedmovent * -1f;
        }


        if (plataforma.transform.position.y < positionmin.position.y && speedmovent < 0)
        {
            speedmovent = speedmovent * -1f;
        }


        /* if (plataforma.transform.position.y > positionmax.position.y)
        {
            speedmovent = -5f;
        }
        

        if (plataforma.transform.position.y < positionmin.position.y)
        {   
            speedmovent =   5f;
        }*/

    }
        
}
