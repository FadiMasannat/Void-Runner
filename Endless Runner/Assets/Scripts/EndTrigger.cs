using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour

{
    public GameManager gamemanager;
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Finish")
        {
            gamemanager.CompleteLevel();
        }
        
    }
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
