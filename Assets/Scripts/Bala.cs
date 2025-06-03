using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{

    public Vector3 direccion;

    public float rangoBala = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        transform.right = direccion;
        Destroy(this.gameObject, rangoBala);

    }
    /* void OnTriggerEnter2D(Collider2D other)
    {
        

    }
*/
    
    void OnTriggerEnter2D(Collider2D other)
    {
         if (other.gameObject.CompareTag("Wall"))

        {
            Destroy(this.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {


        //transform.position += direccion * velocidad * Time.deltaTime;


    }
}
