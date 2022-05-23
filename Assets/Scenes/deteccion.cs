using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deteccion : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("el objeto entró");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("El objeto esta permaneciendo adentro ");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("El objeto Salió");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
