using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check : MonoBehaviour
{ 
    private float Fdistance = 700f;
    private float Mdistance = 350f;
    private float Cdistance = 200f;
    public GameObject key, close, med, far, blank, canvas;

    // Start is called before the first frame update
    void Start()
    {
        key = GameObject.Find("Key");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            
            if (Vector3.Distance(key.transform.position, transform.position) <= Cdistance)
            {
                Instantiate(close, canvas.transform);
                Destroy(close, 1.0f);
            }
            else if (Vector3.Distance(key.transform.position, transform.position) <= Mdistance)
            {
                Instantiate(med, canvas.transform);
                Destroy(med, 1.0f);
            }
            else if (Vector3.Distance(key.transform.position, transform.position) <= Fdistance)
            {
                Instantiate(far, canvas.transform);
                Destroy(far, 1.0f);
            }
            else
            {
                Instantiate(blank, canvas.transform);
                Destroy(blank, 1.0f);
            }
        }
        
    }
}
