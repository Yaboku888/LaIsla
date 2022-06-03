using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script: MonoBehaviour
{
    public float velocidadMovimiento = 5.0f;
    public float velocidadRotacion = 200.0f;
    private Animator anim2;
    public float x, y;

        void Start()
    {
        anim2 = GetComponent<Animator>();  

    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0, x * Time.deltaTime * velocidadMovimiento, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);
    }
}
