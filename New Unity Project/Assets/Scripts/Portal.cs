using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject cube;
    public GameObject canvas;
    public GameObject parentObj;
    public bool hasMoved;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("collided !");
            parentObj.GetComponent<CharacterController>().enabled = false;
            parentObj.transform.position = cube.transform.position;
            parentObj.GetComponent<CharacterController>().enabled = true;
            

        }
    }
}
