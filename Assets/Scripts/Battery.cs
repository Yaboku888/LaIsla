using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    //variable para hacer referencia al sonido
    public AudioSource source;
    public AudioClip soundFX;
    public void desaparecer()
    {

        //mover el sonido   
        //posicion de la bateria = posicion del transform que tiene este script
        //source.transform.position = transform.position;

        //Reproducir el sonido
        // source.PlayOneShot(soundFX);

        AudioSource.PlayClipAtPoint(soundFX, gameObject.transform.position);
        Destroy(gameObject);
    }

}
