using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatMePopUp  : MonoBehaviour
{
    private Camera cam;
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.forward = cam.transform.forward;
    }
}
