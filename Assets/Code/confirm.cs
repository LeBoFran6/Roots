using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirm : MonoBehaviour
{
    public List<string> saveplayers = new List<string>();
    public int action;
    public selectTrees selecttrees;
    public GameObject leftArrow;
    public GameObject rightArrow;

    private int SavedListChoice;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recup()
    {
        SavedListChoice = PlayerPrefs.GetInt("Count");

        for (int i = 0; i < SavedListChoice; i++)
        {
            string choice = PlayerPrefs.GetString("choice" + selecttrees.playerid);
            selecttrees.PlayersChoice.Add(choice);


        }
    }

    public void valider()
    {
            leftArrow.SetActive(false);
            rightArrow.SetActive(false);
            Debug.Log(action + "  validee");
    }
}
