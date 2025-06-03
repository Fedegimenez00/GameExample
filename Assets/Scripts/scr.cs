using Unity.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class scr : MonoBehaviour


{



    private SpriteRenderer spriteRenderer;

    public float velocidad = 2f;

    public float velocidadBala = 3f;
    public float axisHorizontal = 0;
    public float axisVertical = 0;

    public Rigidbody2D miRigidBody;

    //Agregado del movimiento de bala
    public GameObject balaPrefab;
    public Vector3 direccion;

    //Colores
    public SpriteRenderer miRenderer;

    public Color color1;
    public Color color2;
    public Color color3;

    public float cadenciaDeTiro;
    public float TiempoDesdeUltimoTiro;

    public 
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        TiempoDesdeUltimoTiro += Time.deltaTime;

        

        direccion = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0).normalized;

        //El movimiento se basa en el rigid body                                                          ayuda
        miRigidBody.velocity = direccion * velocidad;

        // transform.position += direccion * Time.deltaTime * velocidad;


        if (Input.GetKey(KeyCode.Space) && TiempoDesdeUltimoTiro > cadenciaDeTiro)
        {
            Debug.Log("Aprete espacios");
            if (direccion != Vector3.zero)
            {
                // Instanciamos una copia del prefab
                GameObject nuevaBala = Instantiate(balaPrefab);
                nuevaBala.transform.position = transform.position + direccion * 0.15f;

                // Le damos la dirección a la bala
                nuevaBala.GetComponent<Bala>().direccion = direccion;

                nuevaBala.GetComponent<Rigidbody2D>().velocity = direccion * velocidadBala;
                TiempoDesdeUltimoTiro = 0f;


            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            miRenderer.color = color1;

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            miRenderer.color = color2;

        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            miRenderer.color = color3;

        }





    }
}
