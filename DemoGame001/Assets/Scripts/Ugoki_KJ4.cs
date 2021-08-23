using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ugoki_KJ4 : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, -0.03f);

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "RightHandAnchor")
        {
            OVRInput.SetControllerVibration(0f, 1f, OVRInput.Controller.LTouch);
        }
    }
}
