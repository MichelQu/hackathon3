using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controloutline : MonoBehaviour
{

    void OnMouseOver()
    {
        GetComponent<Renderer>().material.SetFloat("_FirstOutlineWidth", 0.02f); 
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.SetFloat("_FirstOutlineWidth", 0f);
    }
}
