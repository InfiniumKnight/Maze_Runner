using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressPlay : MonoBehaviour
{
    public AudioSource announcer;
    public AudioClip Instructions;
    public Canvas Controls;


    public void PlayGame()
    {
        Controls.gameObject.SetActive(true);
        announcer.PlayOneShot(Instructions);
        Invoke("LoadScene",2);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
