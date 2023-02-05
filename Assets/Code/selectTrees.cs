using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectTrees : MonoBehaviour
{
    public GameObject baobab;
    public GameObject cerisier;
    public GameObject erable;
    public GameObject sapin;
    private int indexTree;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (indexTree)
        { 
            case 0:
                baobab.SetActive(true);
                cerisier.SetActive(false);
                erable.SetActive(false);
                sapin.SetActive(false);
                break;
            case 1:
                baobab.SetActive(false);
                cerisier.SetActive(true);
                erable.SetActive(false);
                sapin.SetActive(false);
                break;
            case 2:
                baobab.SetActive(false);
                cerisier.SetActive(false);
                erable.SetActive(true);
                sapin.SetActive(false);
                break;
            case 3:
                baobab.SetActive(false);
                cerisier.SetActive(false);
                erable.SetActive(false);
                sapin.SetActive(true);
                break;
        }
    }

    public void ChangeTreeR()
    {
        indexTree++;
        if (indexTree > 3)
        {
            indexTree = 0;
        }
    }
    public void ChangeTreeL()
    {
        indexTree--;
        Debug.Log(indexTree);
        if (indexTree < 0)
        {
            indexTree = 3;
        }
    }
}
