using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject enemigoPrefab;

    public GameObject Player;
    public float cooldown = 2f;
    float tiempoActual = 0f;


    void Start()
    {
        Player = GameObject.Find("MC");
    }
    void Update()
    {

        tiempoActual += Time.deltaTime;

        if (tiempoActual > cooldown)
        {
            SpawnEnemigo();
            tiempoActual = 0f;
        }
        
    }

    void SpawnEnemigo()
    {
        float x = Random.Range(-2f, 2f);
        float y = Random.Range(-1f, 2f);
        Vector3 offsetSpawn = new Vector3(x, y, 0);

        GameObject enemigoInstanciado = Instantiate(enemigoPrefab);
        enemigoInstanciado.transform.position = offsetSpawn + transform.position;

    }
}

