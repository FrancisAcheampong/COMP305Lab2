using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnChangeSprite : MonoBehaviour {
    //Game Objects and variable
    public GameObject firstSpriteP;
    public Sprite firstSpritep;
   

    private Rigidbody2D rBody;
    private SpriteRenderer sRend;

    // Use this for initialization
    void Start () {
        rBody = firstSpriteP.GetComponent<Rigidbody2D>();
        sRend = firstSpriteP.GetComponent<SpriteRenderer>();
    }

    // on mouse click is called once per frame
    void OnMouseDown()
    {
        if (sRend.sprite == firstSpriteP)
        {
            sRend.sprite = firstSpritep;
        }

    }
}
