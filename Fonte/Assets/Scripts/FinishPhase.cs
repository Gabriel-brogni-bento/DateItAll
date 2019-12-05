using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPhase : MonoBehaviour
{

    private bool blue = false, pink = false;

    //public GameObject NextPhase;
    private NextPhase nextPhase;

    private void Start()
    {
        nextPhase = GameObject.FindGameObjectWithTag("finish").GetComponent<NextPhase>();
    }

    private void Update()
    {
        if(blue && pink)
        {
            nextPhase.ChangePhase();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            blue = true;
        }

        if(collision.gameObject.layer == 12)
        {
            pink = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            blue = false;
        }

        if (collision.gameObject.layer == 12)
        {
            pink = false;
        }
    }
}
