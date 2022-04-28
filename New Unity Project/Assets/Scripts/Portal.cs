using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject character;
    private int count;
    public GameObject position_one;
    public GameObject position_two;
    public GameObject move;
    private GameObject[] positions;
    public GameObject key;
    public GameObject keyWinter, keySummer, keySpring, keyFall;
    // Start is called before the first frame update
    void Start()
    {
        if(this.tag == "Tomb")
        {
            return;
        }
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
            if(this.tag == "FallTomb")
            {
                key.transform.position = keyWinter.transform.position;
                Debug.Log("SHJIIIIHOSHIH");
            }
            else if (this.tag == "WinterTomb")
            {
                key.transform.position = keySpring.transform.position;
                Debug.Log("SHJIIIIHOSHIH");
            }
            else if(this.tag == "SpringTomb")
            {
                key.transform.position = keySummer.transform.position;
                Debug.Log("SHJIIIIHOSHIH");
            }
            else if(this.tag == "SummerTomb")
            {
                key.transform.position = keyFall.transform.position;
                Debug.Log("SHJIIIIHOSHIH");
            }
                Debug.Log("collided !");
                character.GetComponent<CharacterController>().enabled = false;
                character.transform.position = move.transform.position;
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
