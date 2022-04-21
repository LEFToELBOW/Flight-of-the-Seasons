using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject cube;
    public GameObject playerChild;
    public GameObject camera;
    public GameObject canvas;
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
            playerChild.transform.position = cube.transform.position;
            camera.transform.position = cube.transform.position;
            // canvas.transform.position = cube.transform.position;
            Debug.Log(playerChild.transform.position);
        }
    }
}
