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
    public static int choix;

    public int playerid;

    public List<string> PlayersChoice = new List<string>();

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
                //PlayerPrefs.SetString("choix" + playerid, PlayersChoice['0']);
                break;
            case 1:
                baobab.SetActive(false);
                cerisier.SetActive(true);
                erable.SetActive(false);
                sapin.SetActive(false);
                // PlayerPrefs.SetString("choix" + playerid, PlayersChoice['1']);
                break;
            case 2:
                baobab.SetActive(false);
                cerisier.SetActive(false);
                erable.SetActive(true);
                sapin.SetActive(false);
                // PlayerPrefs.SetString("choix" + playerid, PlayersChoice['2']);
                break;
            case 3:
                baobab.SetActive(false);
                cerisier.SetActive(false);
                erable.SetActive(false);
                sapin.SetActive(true);
                // PlayerPrefs.SetString("choix" + playerid, PlayersChoice['3']);
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
