using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class key : MonoBehaviour
{
    public GameObject puerta;
    public GameObject puerta1;

    
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Main character"))
        {
            Destroy(puerta);
            Destroy(puerta1);
            Destroy(this.gameObject);
         }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
