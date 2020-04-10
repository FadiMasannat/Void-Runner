using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0f, -10f, 0f) * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0f, -10f, 0f) * Time.deltaTime);
        }
    }
}
