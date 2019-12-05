using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.layer == 9) || (collision.gameObject.layer == 12))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}