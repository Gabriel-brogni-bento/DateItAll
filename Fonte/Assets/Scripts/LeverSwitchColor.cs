using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverSwitchColor : MonoBehaviour
{
    public Sprite[] sprites;
    public Sprite[] LeverSprite;
    public GameObject[] ChangeColor;

    public bool isPink;

    public bool activateColor;

    //public bool isPink = true;

    private int LeverNumber;

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

        if (activateColor)
        {
            foreach (GameObject go in ChangeColor)
            {
                if (isPink)
                {
                    go.GetComponent<SpriteRenderer>().sprite = sprites[0];
                    go.layer = 11;
                }
                else
                {
                    go.GetComponent<SpriteRenderer>().sprite = sprites[1];
                    go.layer = 10;
                }
            }
        }
        else
        {
            foreach (GameObject go in ChangeColor)
            {
                if (go.layer == 10)
                {
                    go.GetComponent<SpriteRenderer>().sprite = sprites[0];
                    go.layer = 11;
                }
                else if (go.layer == 11)
                {
                    go.GetComponent<SpriteRenderer>().sprite = sprites[1];
                    go.layer = 10;
                }
            }

        }
            gameObject.GetComponent<SpriteRenderer>().sprite = LeverSprite[LeverNumber];

            if (LeverNumber == 0)
            {
                LeverNumber = 1;
            }
            else
            {
                LeverNumber = 0;
            }
        activateColor = false;
        }
    }

