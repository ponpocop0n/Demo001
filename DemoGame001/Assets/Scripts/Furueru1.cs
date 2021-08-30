using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Furueru1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ????????????????
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.LTouch);
        }
        // ????????????????
        if (OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.LTouch);
        }

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Bullet"))
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.LTouch);
        }
    }
    void OnTriggerExit(Collider col)
    { 
        if (col.CompareTag("Bullet"))
        {
            OVRInput.SetControllerVibration(0f, 0f, OVRInput.Controller.LTouch);
        }
    }
}
