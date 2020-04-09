using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool endgame = false;

    public GameObject CompleteLevelUI;

    // Start is called before the first frame update

    public void Endgame()
    {
        if (endgame == false)
        {
            endgame = true;
            Debug.Log("Game Over");
            Invoke("restart", 2f);
        }
    }

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true); 
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
