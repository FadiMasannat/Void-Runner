using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CorrectLevel : MonoBehaviour
{

    public Text selectedlevel;



    // Start is called before the first frame update
    void Start()
    {
        selectedlevel.text = "Level " + SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
