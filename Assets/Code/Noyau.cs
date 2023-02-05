using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Noyau : MonoBehaviour
{
    public GameObject ScriptHolder;
    public GameObject P2;
    public AudioSource EndSound;

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
            ScriptHolder.GetComponent<Player1>().END = true;
            EndSound.Play();
        }
        if (c.gameObject.name == "Player2")
        {
            P2.GetComponent<Player2>().END = true;
            Debug.Log("END");
            EndSound.Play();
        }


    }
}
