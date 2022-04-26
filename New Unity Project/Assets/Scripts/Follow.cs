using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform targetTransform;
    [SerializeField] private float speed = 100.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetTransform.position);
        if ((transform.position - targetTransform.position).magnitude > 0.1f)
        {
            transform.Translate(0.0f, 0.0f, speed * Time.deltaTime);
        }
    }
}
