using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{
    private bool far, med, close;
    private float Fdistance = 200f;
    private float Mdistance = 50f;
    private float Cdistance = 20f;
    public GameObject key;

    // Start is called before the first frame update
    void Start()
    {
        key = GameObject.Find("Key");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(key.transform.position, transform.position) <= Cdistance)
        {

        }
        else if(Vector3.Distance(key.transform.position, transform.position) <= Mdistance)
        {

        }
        else if(Vector3.Distance(key.transform.position, transform.position) <= Fdistance)
        {

        }
        else
        {

        }
    }
}
