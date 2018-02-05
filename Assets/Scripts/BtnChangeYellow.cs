using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnChangeYellow : MonoBehaviour {

    public GameObject firstSpriteY;
    public Sprite thirdSprite;

    private Rigidbody2D rBody;
    private SpriteRenderer sRend;

    // Use this for initialization
    void Start () {

        rBody = firstSpriteY.GetComponent<Rigidbody2D>();
        sRend = firstSpriteY.GetComponent<SpriteRenderer>();
    }

    // Mouse click is called once per frame
    void OnMouseDown()
    {
        if (sRend.sprite == firstSpriteY)
        {
            sRend.sprite = thirdSprite;
        }

    }
}
