using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arma : MonoBehaviour
{
    public GameObject bala;
    public Transform spawnp;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject go = Instantiate(bala, spawnp.position, spawnp.rotation);
            go.GetComponent<Rigidbody>().AddForce(go.transform.forward, ForceMode.Impulse);

            Destroy(go, 2f);
            
        }
    }
}
