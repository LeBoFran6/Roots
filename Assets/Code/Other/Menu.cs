using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public GameObject anim;

    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        anim.gameObject.GetComponent<Animator>().enabled = false;
    }
}
