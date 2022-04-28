using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Check : MonoBehaviour
{ 
    private float Fdistance = 700f;
    private float Mdistance = 350f;
    private float Cdistance = 200f;
    public GameObject key, close, med, far, blank, canvas;
    private bool[] winCon;
    private GameObject keyW, keyS, keySu, keyF;    //0, 1, 2, 3 respectively
    public GameObject endGame, startGame;
    public Text info;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<CharacterController>().enabled = false;
        this.transform.position = startGame.transform.position;
        this.GetComponent<CharacterController>().enabled = true;


        keyW = GameObject.Find("KEYWINTERPOSITION");
        keyS = GameObject.Find("KEYSPRINGPOSITION");
        keySu = GameObject.Find("SUMMERKEYPOSITION");
        keyF = GameObject.Find("KEYFALLPOSITION");


        key = GameObject.Find("Key");
        winCon = new bool[4];
        for(int i = 0; i < winCon.Length; i++)
        {
            winCon[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            
            if (Vector3.Distance(key.transform.position, transform.position) <= Cdistance)
            {
                Destroy(Instantiate(close, canvas.transform), 1.0f);
                if(key.transform.position == keyW.transform.position)
                {
                    Debug.Log("Collected");
                    winCon[0] = true;
                    CheckWin();
                }
                else if(key.transform.position == keyS.transform.position)
                {
                    Debug.Log("Collected");
                    winCon[1] = true;
                    CheckWin();
                }
                else if (key.transform.position == keySu.transform.position)
                {
                    Debug.Log("Collected");
                    winCon[2] = true;
                    CheckWin();
                }
                else if (key.transform.position == keyF.transform.position)
                {
                    Debug.Log("Collected");
                    winCon[3] = true;
                    CheckWin();
                }
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

    public void CheckWin()
    {
        for(int i = 0; i < winCon.Length; i++)
        {
            if(winCon[i] == false)
            {
                return;
            }
            this.GetComponent<CharacterController>().enabled = false;
            this.transform.position = endGame.transform.position;
            this.GetComponent<CharacterController>().enabled = true;
            info.text = "Congratulations! You have collected all four keys, slowing down global climate change for now. Use this newly aquired time to help save the Earth before it is too late!";
        }
          
    }
}
