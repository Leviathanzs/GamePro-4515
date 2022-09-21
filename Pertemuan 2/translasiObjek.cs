using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class translasiObjek : MonoBehaviour
{
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    // Start is called before the first frame update
    void Start()
    {
        keatas = new Vector3(0,1,0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + 
        (keatas * 2f * Time.deltaTime);
    }
}