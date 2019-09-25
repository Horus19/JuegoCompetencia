using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, (float)0.1, 0);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, (float)-0.1, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3((float)-0.1, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3((float)0.1, 0, 0);
        }
    }
}
