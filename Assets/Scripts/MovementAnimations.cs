using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.AI;

public class MovementAnimations : MonoBehaviour

{

    public SpriteRenderer sr;
    public Sprite upSprite;
    public Sprite downSprite;
    public Sprite leftSprite;
    public Sprite rightSprite;   

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal"); // -1 a 1, izquierda o derecha

        float y = Input.GetAxis("Vertical"); // -1 a 1, abajo o arriba

        // Cambio de sprite según dirección

        if (x > 0) sr.sprite = rightSprite;

        else if (x < 0) sr.sprite = leftSprite;
        
        else if (y > 0) sr.sprite = upSprite;

        else if (y < 0) sr.sprite = downSprite;
    }
}
