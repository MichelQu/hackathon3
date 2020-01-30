using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToScene : MonoBehaviour
{

    // Start is called before the first frame update
    public void Update()

    {

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


            if (Physics.Raycast(ray, out hit))
            {


                if (hit.collider.gameObject.name == "Sun")
                {
                    Debug.Log("hello");
                    SceneManager.LoadScene("Earth");
                }

            }


        }

    }
}