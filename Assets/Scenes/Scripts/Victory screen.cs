using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victoryscreen : MonoBehaviour
{
    //public bool quit_test = false;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Quit", 2);
    }

    public void Quit()
    {
        //quit_test = true;
        Application.Quit();
    }
}
