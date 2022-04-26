using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalMake : MonoBehaviour
{
    public GameObject portal_one, portal_two, position_one, position_two, position_three, position_four;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(Instantiate(portal_one, position_one.transform), 15f);
        Destroy(Instantiate(portal_two, position_two.transform), 15f);
        StartCoroutine(WaitCoroutine());
        Destroy(Instantiate(portal_one, position_three.transform), 15f);
        Destroy(Instantiate(portal_two, position_four.transform), 15f);
    }

    IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(15);
    }
}
