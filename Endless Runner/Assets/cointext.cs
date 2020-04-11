using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cointext : MonoBehaviour
{
    public Text Coins;
    public int CoinNum = 0;


    // Start is called before the first frame update
    void Start()
    {
        CoinNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Coins.text = "Coins: " + CoinNum;
        Debug.Log(CoinNum);
    }
}
