using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lave : MonoBehaviour
{

    public GameObject ScriptHolder;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public AudioSource BurntSound;
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
            ScriptHolder.GetComponent<Player1>().lave = true;
            BurntSound.Play();
        }
        if (c.gameObject.name == "Player2")
        {
            P2.GetComponent<Player2>().lave = true;
            BurntSound.Play();
        }
        if (c.gameObject.name == "Player3")
        {
            P3.GetComponent<Player3>().lave = true;
            BurntSound.Play();
        }
        if (c.gameObject.name == "Player4")
        {
            P4.GetComponent<Player4>().lave = true;
            BurntSound.Play();
        }


    }
}
