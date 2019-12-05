using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NextPhase : MonoBehaviour
{
    private Color loadToColor = Color.black;

    private string Phase = "Game";
    private static float Number = 1;
    
    public void ChangePhase()
    {
        if (Number < 10)
        {
            Initiate.Fade(loadToColor, 0.8f);
            StartCoroutine("Phaselessthen10");
        }
        else
        {
            Initiate.Fade(loadToColor, 0.8f);
            StartCoroutine("Phasemorethen10");
        }
    }


    public IEnumerator Phaselessthen10()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        SceneManager.LoadScene(Phase + "0" + Number);
        Number++;
        StopCoroutine("Phaselessthen10");
    }

    public IEnumerator Phasemorethen10()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        if(Number == 18)
        {
            SceneManager.LoadScene("Menu");
            Number = 1;
            StopCoroutine("Phasemorethen10");
        }
        else
        {
            SceneManager.LoadScene(Phase + Number);
            Number++;
            StopCoroutine("Phasemorethen10");
        }
    }


    public void HomeButton()
    {
        Initiate.Fade(loadToColor, 0.8f);
        StartCoroutine("menu");
    }


    public IEnumerator menu()
    {
        yield return new WaitForSecondsRealtime(1.5f);
        SceneManager.LoadScene("Menu");
        Number = 1;
        StopCoroutine("menu");
    }
}
