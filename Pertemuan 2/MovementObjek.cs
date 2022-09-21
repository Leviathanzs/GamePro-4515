using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementObjek : MonoBehaviour
{
    Vector3 maju;
    Vector3 mundur;
    Vector3 keatas;
    Vector3 kebawah;

    public int aksi;
    // Start is called before the first frame update
    void Start()
    {
        maju = new Vector3(-1,0,0);
        mundur = new Vector3(1,0,0);
        keatas = new Vector3(0,1,0);
        kebawah = new Vector3(0,-1,0);
    }

    // Update is called once per frame
    void Update()
    {
        switch (aksi)
        {
            case 0:
                transform.position = transform.position + (maju * 2f * Time.deltaTime);
                break;
            
            case 1:
                transform.position = transform.position + (mundur * 2f * Time.deltaTime);
                break;

            case 2:
                transform.position = transform.position + (keatas * 2f * Time.deltaTime);
                break;

            case 3:
                transform.position = transform.position + (kebawah * 2f * Time.deltaTime);
                break;
        }
    }
}
