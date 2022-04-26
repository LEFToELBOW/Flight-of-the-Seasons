using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject cube;
    public GameObject character;
    private int count;
    public GameObject position_one;
    public GameObject position_two;
    public GameObject move1, move2;
    private GameObject[] positions;
    // Start is called before the first frame update
    void Start()
    {
        count = 1;
        this.transform.position = position_one.transform.position;
        positions = new GameObject[2];
        positions[0] = position_one;
        positions[1] = position_two;
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
            character.GetComponent<CharacterController>().enabled = false;
            character.transform.position = cube.transform.position;
            character.GetComponent<CharacterController>().enabled = true;
            this.transform.position = positions[count].transform.position;
            CountUpdate();
        }
    }

    void CountUpdate()
    {
        if (count == 1)
            count--;
        else
            count++;
    }
}
