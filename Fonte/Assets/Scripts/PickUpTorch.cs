using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.LWRP;

public class PickUpTorch : MonoBehaviour
{

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
        if (collision.gameObject.CompareTag("BluePlayer"))
        {
            gameObject.SetActive(false);
            collision.gameObject.GetComponent<Light2D>().intensity = 0.68f;
        }

        if (collision.gameObject.CompareTag("PinkPlayer"))
        {
            gameObject.SetActive(false);
            collision.gameObject.GetComponent<Light2D>().intensity = 0.68f;
        }
    }
    
}
