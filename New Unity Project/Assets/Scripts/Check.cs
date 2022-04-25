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
                Destroy(Instantiate(close, canvas.transform), 1.0f);
            }
            else if (Vector3.Distance(key.transform.position, transform.position) <= Mdistance)
            {
                Destroy(Instantiate(med, canvas.transform), 1.0f);
            }
            else if (Vector3.Distance(key.transform.position, transform.position) <= Fdistance)
            {
                Destroy(Instantiate(far, canvas.transform), 1.0f);
            }
            else
            {
                Destroy(Instantiate(blank, canvas.transform), 1.0f);
            }
        }
        
    }
}
