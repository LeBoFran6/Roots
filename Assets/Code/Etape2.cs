using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Etape2 : MonoBehaviour
{

    public GameObject ScriptHolder;
    public GameObject P2;
    public AudioSource MusicLayer_2;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "Player1")
        {
            ScriptHolder.GetComponent<Player1>().Etape2 = true;
            Debug.Log("OOOOOOOOOOOOOO");
            SetVolume();
        }
        if (c.gameObject.name == "Player2")
        {
            P2.GetComponent<Player2>().Etape2 = true;
            Debug.Log("HHHHHHHHHHHHH");
            SetVolume();
        }
    }

    private void SetVolume()
    {
        while (MusicLayer_2.volume != 1)
            {
                MusicLayer_2.volume += 0.1f ;
            }
    }
}
