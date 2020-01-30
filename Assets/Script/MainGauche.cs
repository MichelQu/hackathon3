using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class MainGauche : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = InputTracking.GetLocalPosition(XRNode.LeftHand) + GameObject.Find("Root").transform.position;
        print(Input.GetAxis("Fire1"));
    }
}
