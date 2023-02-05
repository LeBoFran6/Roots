using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Arbre;
    public GameObject GameOver;
    public GameObject GameOverCanva;
    public GameObject Baobab;
    public GameObject Cerisier;
    public GameObject Erable;
    public GameObject Sapin;
    
    public AudioSource GrowSound;
    public AudioSource EndSound;
    public AudioSource WooshSound;
    
    public bool Mooving = false;
    public bool Obstacle1;
    public bool lave;
    public bool Etape2 = false;
    public bool Etape3 = false;
    public bool END = false;
    
    public float random;

    // je stocke en local l'id de larbre
    private int treeId;
    
    // Start is called before the first frame update
    void Start()
    {
        // ici je récupère l'index de l'arbre choisi par le J2 et je l'assigne à treeID
        treeId = PlayerPrefs.GetInt("ArbreJ2");

        switch (treeId)
        {
            case 0:
                Baobab.SetActive(true);
                Cerisier.SetActive(false);
                Erable.SetActive(false);
                Sapin.SetActive(false);
                break;
            
            case 1:
                Cerisier.SetActive(true);
                Baobab.SetActive(false);
                Erable.SetActive(false);
                Sapin.SetActive(false);
                break;
            
            case 2:
                Erable.SetActive(true);
                Baobab.SetActive(false);
                Cerisier.SetActive(false);
                Sapin.SetActive(false);
                break;
            
            case 3:
                Sapin.SetActive(true);
                Baobab.SetActive(false);
                Cerisier.SetActive(false);
                Erable.SetActive(false);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {


        random = Random.Range(-0.1f, 0.1f);



        if (lave == true)
        {
            GameOver.SetActive(true);
            //lave = false;

        }


        if (lave == false || END == false)
        {

            if (Input.GetKey(KeyCode.K))
            {
                if (Input.GetKeyDown(KeyCode.O))
                {
                    if (Obstacle1 == true)
                    {
                        Mooving = true;
                        Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(-0.08f, 0.03f, 0);
                        //Debug.Log("Space Q.");
                        Obstacle1 = false;
                    }/*
                if(Etape2 == true)
                {
                    Mooving = true;
                    Instantiate(Arbre1, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                    Player.transform.position = Player.transform.position + new Vector3(-0.08f, -0.3f, 0);
                    Debug.Log("SUUUUUUUUUUUUUUUUU.");
                    Etape2 = false;
                }*/
                    else
                    {
                        Mooving = true;
                        Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(-0.15f, 0.07f, 0);
                        //Debug.Log("Space Q.");
                    }

                }
            }

            if (Input.GetKey(KeyCode.M))
            {
                if (Input.GetKeyDown(KeyCode.O))
                {
                    if (Obstacle1 == true)
                    {
                        Mooving = true;
                        Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(0.08f, 0.03f, 0);
                        //Debug.Log("Space D.");
                        Obstacle1 = false;
                    }/*
                if (Etape2 == true)
                {
                    Mooving = true;
                    Instantiate(Arbre1, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                    Player.transform.position = Player.transform.position + new Vector3(0.08f, -0.3f, 0);
                    Debug.Log("SUUUUUUUUUUUUUUUUU.");
                    Etape2 = false;
                }*/
                    else
                    {
                        Mooving = true;
                        Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(0.15f, 0.07f, 0);
                        //Debug.Log("Space D.");
                    }

                }
            }


            if (Input.GetKeyDown(KeyCode.O) && Mooving == false)
            {
                GrowSound.Play(
                    );
                if (Etape3 == true)
                {

                    Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                    Player.transform.position = Player.transform.position + new Vector3(random, 0.2f, 0);
                    //Debug.Log("SUUUUUUUUUUUUUUUUU.");
                    Etape2 = false;
                }
                if (Etape2 == true)
                {

                    Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                    Player.transform.position = Player.transform.position + new Vector3(random, 0.15f, 0);
                    //Debug.Log("SUUUUUUUUUUUUUUioioioiUUU.");
                    //Etape2 = false;
                }
                if (Obstacle1 == true)
                {
                    Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                    Player.transform.position = Player.transform.position + new Vector3(random, 0.03f, 0);
                    //Debug.Log("Space key was pressed.");
                }
                else
                {
                    Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                    Player.transform.position = Player.transform.position + new Vector3(random, 0.09f, 0);
                    //Debug.Log("Space key was pressed.");
                }
            }
        }




        if (END == true)
        {
            Debug.Log("OOOOOOOOOOOOOO");
            EndSound.Play();
            WooshSound.Play();
            GameOverCanva.SetActive(true);
        }




        Mooving = false;



        if (Player.transform.position.y >= 0)
        {
            //Debug.Log("GameOver");
            //GameOver.SetActive(true);
            EndSound.Play();
            WooshSound.Play();
            GameOverCanva.SetActive(true);
        }

    }
}
