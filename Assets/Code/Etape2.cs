using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Etape2 : MonoBehaviour
{

    public GameObject ScriptHolder;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public AudioSource MusicLayer_2;
    public GameObject map;
    
    public Vector3 rotateAmount;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        map.transform.Rotate(rotateAmount * Time.deltaTime);
        
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "Player1")
        {
            ScriptHolder.GetComponent<Player1>().Etape2 = true;
            //Debug.Log("OOOOOOOOOOOOOO");
            SetVolume();
            rotateAmount = new Vector3(0, 0, 2);
        }
        if (c.gameObject.name == "Player2")
        {
            P2.GetComponent<Player2>().Etape2 = true;
            //Debug.Log("HHHHHHHHHHHHH");
            SetVolume();
            rotateAmount = new Vector3(0, 0, 2);
        }
        if (c.gameObject.name == "Player3")
        {
            P3.GetComponent<Player3>().Etape2 = true;
            //Debug.Log("HHHHHHHHHHHHH");
            SetVolume();
            rotateAmount = new Vector3(0, 0, 2);
        }
        if (c.gameObject.name == "Player4")
        {
            P4.GetComponent<Player4>().Etape2 = true;
            //Debug.Log("HHHHHHHHHHHHH");
            SetVolume();
            rotateAmount = new Vector3(0, 0, 2);
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
