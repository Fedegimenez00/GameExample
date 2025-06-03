using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ice : MonoBehaviour
{
public GameObject Personaje;
    public Color MiColor;
public SpriteRenderer PersonajeRenderer;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Main character"))
        {
            collision.gameObject.GetComponent<SpriteRenderer>().color = MiColor;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
