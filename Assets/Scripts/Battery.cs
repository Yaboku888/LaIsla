using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    //variable para hacer referencia al sonido
    public AudioSource source;
    public AudioClip soundFX;
    public float volumen = 1;
    public void desaparecer()
    {

        gameObject.SetActive(false);

        source.transform.position = transform.position;
        source.PlayOneShot(soundFX, volumen);
        //mover el sonido   
        //posicion de la bateria = posicion del transform que tiene este script
        //source.transform.position = transform.position;

        //Reproducir el sonido
        // source.PlayOneShot(soundFX);

        //A udioSource.PlayClipAtPoint(soundFX, gameObject.transform.position);
        //Destroy(gameObject);
    }

}
