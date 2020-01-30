using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public GameObject sun;
    float rotate_time = 5.0f;
    public float period;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(sun.transform.position, Vector3.up, 30* (365/period) * Time.deltaTime);
        transform.RotateAround(transform.position, Vector3.up, 30*Time.deltaTime);
    }
}
