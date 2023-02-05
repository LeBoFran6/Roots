using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectTrees : MonoBehaviour
{
    public GameObject baobab;
    public GameObject cerisier;
    public GameObject erable;
    public GameObject sapin;
    public int indexTree;

    public int playerid;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        
        /* for (playerid = 0; playerid <4; playerid++)
         {*/
        switch (indexTree)
        {
            case 0:
                baobab.SetActive(true);
                cerisier.SetActive(false);
                erable.SetActive(false);
                sapin.SetActive(false);
                switch (playerid)
                {
                    case 0:
                        PlayerPrefs.SetInt("ArbreJ1",indexTree);
                        break;
                    case 1:
                        PlayerPrefs.SetInt("ArbreJ2",indexTree);
                        break;
                    case 2:
                        PlayerPrefs.SetInt("ArbreJ3",indexTree);
                        break;
                    case 3:
                        PlayerPrefs.SetInt("ArbreJ4",indexTree);
                        break;
                }
                break;
            case 1:
                baobab.SetActive(false);
                cerisier.SetActive(true);
                erable.SetActive(false);
                sapin.SetActive(false);
                switch (playerid)
                {
                    case 0:
                        PlayerPrefs.SetInt("ArbreJ1",indexTree);
                        break;
                    case 1:
                        PlayerPrefs.SetInt("ArbreJ2",indexTree);
                        break;
                    case 2:
                        PlayerPrefs.SetInt("ArbreJ3",indexTree);
                        break;
                    case 3:
                        PlayerPrefs.SetInt("ArbreJ4",indexTree);
                        break;
                }
                break;
            case 2:
                baobab.SetActive(false);
                cerisier.SetActive(false);
                erable.SetActive(true);
                sapin.SetActive(false);
                switch (playerid)
                {
                    case 0:
                        PlayerPrefs.SetInt("ArbreJ1",indexTree);
                        break;
                    case 1:
                        PlayerPrefs.SetInt("ArbreJ2",indexTree);
                        break;
                    case 2:
                        PlayerPrefs.SetInt("ArbreJ3",indexTree);
                        break;
                    case 3:
                        PlayerPrefs.SetInt("ArbreJ4",indexTree);
                        break;
                }
                break;
            case 3:
                baobab.SetActive(false);
                cerisier.SetActive(false);
                erable.SetActive(false);
                sapin.SetActive(true);
                switch (playerid)
                {
                    case 0:
                        PlayerPrefs.SetInt("ArbreJ1",indexTree);
                        break;
                    case 1:
                        PlayerPrefs.SetInt("ArbreJ2",indexTree);
                        break;
                    case 2:
                        PlayerPrefs.SetInt("ArbreJ3",indexTree);
                        break;
                    case 3:
                        PlayerPrefs.SetInt("ArbreJ4",indexTree);
                        break;
                }
                break;
        }
        // PlayerPrefs.SetInt("Count", PlayersChoice.Count);
    /*}*/
        
    }

    public void ChangeTreeR()
    {
        indexTree++;        
        if (indexTree > 3)
        {
            indexTree = 0;
        }
        Debug.Log(indexTree);
    }
    public void ChangeTreeL()
    {
        indexTree--;        
        if (indexTree < 0)
        {
            indexTree = 3;
        }
        Debug.Log(indexTree);
    }
}
