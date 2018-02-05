using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnChangeGreen : MonoBehaviour {
    public GameObject firstSpriteG;
    public Sprite secondSprite;


    private Rigidbody2D rBody;
    private SpriteRenderer sRend;
    // Use this for initialization
    void Start () {
        rBody = firstSpriteG.GetComponent<Rigidbody2D>();
        sRend = firstSpriteG.GetComponent<SpriteRenderer>();
    }

    // Mouse Click is called 
    void OnMouseDown()
    {
        if (sRend.sprite == firstSpriteG)
        {
            sRend.sprite = secondSprite;
        }

    }

}
