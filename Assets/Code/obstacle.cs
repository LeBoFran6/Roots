using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{

    public GameObject ScriptHolder;
    public GameObject P2;

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
            ScriptHolder.GetComponent<Player1>().Obstacle1 = true;
        }
        if (c.gameObject.name == "Player2")
        {
            P2.GetComponent<Player2>().Obstacle1 = true;
        }


    }
}
