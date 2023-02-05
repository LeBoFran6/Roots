using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Etape3 : MonoBehaviour
{
    public GameObject ScriptHolder;
    public GameObject P2;
    public AudioSource MusicLayer_3;
    public GameObject map;

    private Vector3 rot;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        map.transform.Rotate(rot * Time.deltaTime);
    }



    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "Player1")
        {
            ScriptHolder.GetComponent<Player1>().Etape3 = true;
            SetVolume();
            rot.z = 4;
        }

        if (c.gameObject.name == "Player2")
        {
            P2.GetComponent<Player2>().Etape3 = true;
            SetVolume();
            rot.z = 4;
        }
    }

    private void SetVolume()
    {
        while (MusicLayer_3.volume != 1)
        {
            MusicLayer_3.volume += 0.1f ;
        }
    }
}
