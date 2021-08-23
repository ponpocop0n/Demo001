using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KenjuuMaker : MonoBehaviour
{
    float speed;
    float zikan;
    public GameObject Obj;
    public AudioSource audio;
    public AudioClip koukaon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(0.1f, 2f);
        if (Time.fixedTime - zikan > speed)
        {
            audio.PlayOneShot(koukaon);
            Instantiate(Obj, new Vector3(0.1f, 1.25f, 5.8f), Quaternion.identity);
            zikan = Time.fixedTime;
        }
       
    }
}
