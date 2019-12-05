using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTile : MonoBehaviour
{

    public Sprite[] sprites;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[1];
            gameObject.layer = 11;
        }
        else if (collision.gameObject.layer == 12)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprites[2];
            gameObject.layer = 10;
        }
    }
}
