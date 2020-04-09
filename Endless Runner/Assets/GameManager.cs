using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool endgame = false;


    // Start is called before the first frame update

    public void Endgame()
    {
        if (endgame == false)
        {
            endgame = true;
            Debug.Log("Game Over");
            restart();
        }
    }


    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
