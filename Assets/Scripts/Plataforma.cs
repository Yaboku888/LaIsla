using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public GameObject plataforma;
    public GameObject boton;

    public Transform positionmin;
    public Transform positionmax;
    public float speedmovent;

    private void OnTriggerStay(Collider other)
    {
        if (other !=null)
        {
            MovePlataform();
        }
    }

    private void MovePlataform()
    {
        plataforma.transform.Translate(Vector3.up * Time.deltaTime * speedmovent);

    }
}
