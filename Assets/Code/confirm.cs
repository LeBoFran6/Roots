using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirm : MonoBehaviour
{
    public int choice;
    public selectTrees selecttrees;
    public GameObject leftArrow;
    public GameObject rightArrow;
    public GameObject StartButton;
    public AudioSource BaobabSound;
    public AudioSource CerisierSound;
    public AudioSource ErableSound;
    public AudioSource SapinSound;

    private bool J1Valide;
    private bool J2Valide;
    private bool J3Valide;
    private bool J4Valide;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DisplayStart();
    }

    public void recup()
    {
        
        switch (selecttrees.playerid)
        {
            case 0:
                choice = PlayerPrefs.GetInt("ArbreJ1");
                Debug.Log(choice);
                break;
            case 1:
                choice = PlayerPrefs.GetInt("ArbreJ2");
                Debug.Log(choice);
                break;
            case 2:
                choice = PlayerPrefs.GetInt("ArbreJ3");
                Debug.Log(choice);
                break;
            case 3:
                choice = PlayerPrefs.GetInt("ArbreJ4");
                Debug.Log(choice);
                break;
        }
    }

    public void valider()
    {
            leftArrow.SetActive(false);
            rightArrow.SetActive(false);
            switch (selecttrees.playerid)
            {
                case 0:
                    choice = PlayerPrefs.GetInt("ArbreJ1");
                    J1Valide = true;
                    Debug.Log(choice + " J1 valide");
                    PlayTreeSound();
                    break;
                case 1:
                    choice = PlayerPrefs.GetInt("ArbreJ2");
                    J2Valide = true;
                    Debug.Log(choice + " J2 valide");
                    PlayTreeSound();
                    break;
                case 2:
                    choice = PlayerPrefs.GetInt("ArbreJ3");
                    J3Valide = true;
                    Debug.Log(choice + " J3 valide");
                    PlayTreeSound();
                    break;
                case 3:
                    choice = PlayerPrefs.GetInt("ArbreJ4");
                    J4Valide = true;
                    Debug.Log(choice + " J3 valide");
                    PlayTreeSound();
                    break;
            }
            
    }

    public void DisplayStart()
    {
        if (J1Valide || J2Valide || J3Valide || J4Valide )
        {
            StartButton.SetActive(true);
        }
    }

    public void PlayTreeSound()
    {
        switch (choice)
        {
            case 0:
                BaobabSound.Play();
                break;
            case 1:
                CerisierSound.Play();
                break;
            case 2:
                ErableSound.Play();
                break;
            case 3:
                SapinSound.Play();
                break;
        }
    }
}
