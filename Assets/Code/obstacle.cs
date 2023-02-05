using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{

    public GameObject ScriptHolder;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public AudioSource CollisionSound;

    // Start is called before the first frame update
    void Start()
    {
        //ScriptHolder = FindObjectOfType<GameObject>().name;
        ScriptHolder = GameObject.Find("Player1");
        P2 = GameObject.Find("Player2");
        P3 = GameObject.Find("Player3");
        P4 = GameObject.Find("Player4");
        CollisionSound = GameObject.Find("Blocked").GetComponent<AudioSource>();
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
            CollisionSound.Play();
        }
        if (c.gameObject.name == "Player2")
        {
            P2.GetComponent<Player2>().Obstacle1 = true;
            CollisionSound.Play();
        }
        if (c.gameObject.name == "Player3")
        {
            P3.GetComponent<Player3>().Obstacle1 = true;
            CollisionSound.Play();
        }
        if (c.gameObject.name == "Player4")
        {
            P4.GetComponent<Player4>().Obstacle1 = true;
            CollisionSound.Play();
        }



    }
}
