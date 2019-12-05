using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton : MonoBehaviour
{

    public Sprite[] sprites;
    public GameObject changecolor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("PinkPlayer"))
        {
            changecolor.GetComponent<SpriteRenderer>().sprite = sprites[2];
            changecolor.layer = 10;
        }

        if (collision.gameObject.CompareTag("BluePlayer"))
        {
            changecolor.GetComponent<SpriteRenderer>().sprite = sprites[1];
            changecolor.layer = 11;
        }

        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        changecolor.GetComponent<SpriteRenderer>().sprite = sprites[0];
        changecolor.layer = 0;
    }
}
