using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Pause : MonoBehaviour
{
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            isPaused = !isPaused;
        if (isPaused)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;

    }

    void OnGUI()
    {
        if (isPaused)
        {
            if(GUI.Button(new Rect(Screen.width - 100, 20, 80, 40), "Continuer"))
            {
                isPaused = false;
            }
        }

        if (!isPaused)
        {
            if (GUI.Button(new Rect(Screen.width - 100,  20, 80, 40), "Pause"))
            {
                isPaused = true;
            }
        }
    }
}
