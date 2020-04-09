using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{

    public Transform player;
    public Text scoretext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = player.position.z.ToString("0");
    }
}
