using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class RetourScenePrincipale : MonoBehaviour
{

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width - 100, 60, 80, 40), "Retour"))
        {
            SceneManager.LoadScene("test");
        }
    }
}
