using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public int vida = 3;
    public GameObject balaPrefab;

    public Rigidbody2D enemyRigidBody;

    public GameObject referenciaPlayer;
    public Transform player;
    public float velocidad = 2f;

    public Vector3 direccion;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("HOLA");
            vida--;
            Destroy(other.gameObject); // Destruir la bala

            if (vida <= 0)
                Destroy(this.gameObject); // Muerte  
        }
                

    }
    void Update()
    {

        enemyRigidBody.velocity = (referenciaPlayer.transform.position - this.transform.position).normalized * velocidad;
       
       
     }

    
}

