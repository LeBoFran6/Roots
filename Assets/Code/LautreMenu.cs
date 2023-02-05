using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LautreMenu : MonoBehaviour
{


    public float P1;
    public float P2;
    public float P3;
    public float P4;

    public float quellePlayer = 0;


    public GameObject TP1;
    public GameObject TP2;
    public GameObject TP3;
    public GameObject TP4;

    public GameObject PLAY;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if(quellePlayer == 1)
        {
            TP1.SetActive(false);
            TP2.SetActive(true);
            
        }
        if (quellePlayer == 2)
        {
            TP2.SetActive(false);
            TP3.SetActive(true);
            PLAY.SetActive(true);
        }
        if (quellePlayer == 3)
        {
            TP3.SetActive(false);
            TP4.SetActive(true);
        }





    }

    public void Arbre1()
    {
        if (quellePlayer == 3)
        {
            P4 = 1;
            Debug.Log("LeJeuSeLanceS");
        }
        if (quellePlayer == 2)
        {
            P3 = 1;
            quellePlayer = 3;
        }
        if (quellePlayer == 1)
        {
            P2 = 1;
            quellePlayer = 2;
        }
     
       
        if (quellePlayer == 0)
        {
            P1 = 1;
            quellePlayer = 1;
        }

       

        
       


    }
    public void Arbre2()
    {
        if (quellePlayer == 3)
        {
            P4 = 2;
            Debug.Log("LeJeuSeLanceS");
        }
        if (quellePlayer == 2)
        {
            P3 = 2;
            quellePlayer = 3;
        }
        if (quellePlayer == 1)
        {
            P2 = 2;
            quellePlayer = 2;
        }


        if (quellePlayer == 0)
        {
            P1 = 2;
            quellePlayer = 1;
        }
    }
    public void Arbre3()
    {
        if (quellePlayer == 3)
        {
            P4 = 3;
            Debug.Log("LeJeuSeLanceS");
        }
        if (quellePlayer == 2)
        {
            P3 = 3;
            quellePlayer = 3;
        }
        if (quellePlayer == 1)
        {
            P2 = 3;
            quellePlayer = 2;
        }


        if (quellePlayer == 0)
        {
            P1 = 3;
            quellePlayer = 1;
        }
    }
    public void Arbre4()
    {
        if (quellePlayer == 3)
        {
            P4 = 4;
            Debug.Log("LeJeuSeLanceS");
        }
        if (quellePlayer == 2)
        {
            P3 = 4;
            quellePlayer = 3;
        }
        if (quellePlayer == 1)
        {
            P2 = 4;
            quellePlayer = 2;
        }


        if (quellePlayer == 0)
        {
            P1 = 4;
            quellePlayer = 1;
        }
    }

}
