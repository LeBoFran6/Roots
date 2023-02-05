using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player3 : MonoBehaviour
{
    public GameObject Player;
    public GameObject PLAYER1;
    public GameObject PLAYER2;
    public GameObject PLAYER3;
    public GameObject Arbre;
    public GameObject GameOver;
    public GameObject GameOverCanva;
    public GameObject Baobab;
    public GameObject Cerisier;
    public GameObject Erable;
    public GameObject Sapin;

    public GameObject Noyau;

    public AudioSource GrowSound;
    public AudioSource EndSound;
    public AudioSource WooshSound;

    public Material Material1P2;
    public Material MatR1;
    public Material MatR2;
    public Material MatR3;
    public Material MatR4;

    public bool Mooving = false;
    public bool Obstacle1;
    public bool lave;
    public bool Etape2 = false;
    public bool Etape3 = false;
    public bool END = false;

    public float random;
    public float endCount = 0;

    public GameObject Explosion;

    // je stocke en local l'id de larbre
    private int treeId;

    public TextMeshProUGUI Score;

    // Start is called before the first frame update
    void Start()
    {
        // ici je récupère l'index de l'arbre choisi par le J2 et je l'assigne à treeID
        treeId = PlayerPrefs.GetInt("ArbreJ3");
        Score = GameOverCanva.GetComponentInChildren<TextMeshProUGUI>();

        switch (treeId)
        {
            case 0:
                Baobab.SetActive(true);
                Cerisier.SetActive(false);
                Erable.SetActive(false);
                Sapin.SetActive(false);
                Arbre.GetComponent<MeshRenderer>().material = MatR1;
                break;

            case 1:
                Cerisier.SetActive(true);
                Baobab.SetActive(false);
                Erable.SetActive(false);
                Sapin.SetActive(false);
                Arbre.GetComponent<MeshRenderer>().material = MatR2;
                break;

            case 2:
                Erable.SetActive(true);
                Baobab.SetActive(false);
                Cerisier.SetActive(false);
                Sapin.SetActive(false);
                Arbre.GetComponent<MeshRenderer>().material = MatR3;
                break;

            case 3:
                Sapin.SetActive(true);
                Baobab.SetActive(false);
                Cerisier.SetActive(false);
                Erable.SetActive(false);
                Arbre.GetComponent<MeshRenderer>().material = MatR4;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {


        random = Random.Range(-0.1f, 0.1f);



        if (lave == true)
        {
            // GameOver.SetActive(true);
            Player.transform.position = new Vector3(-12.25f, 0, -0.1f);
            lave = false;

        }


        if (lave == false)
        {

            if (END == false)
            {

                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    if (Input.GetKeyDown(KeyCode.LeftArrow))
                    {
                        if (Obstacle1 == true)
                        {
                            Mooving = true;
                            Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                            Player.transform.position = Player.transform.position + new Vector3(0.03f , 0.08f, 0);
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
                            Player.transform.position = Player.transform.position + new Vector3(0.07f , 0.15f, 0);
                            //Debug.Log("Space Q.");
                        }

                    }
                }

                if (Input.GetKey(KeyCode.RightArrow))
                {
                    if (Input.GetKeyDown(KeyCode.RightArrow))
                    {
                        if (Obstacle1 == true)
                        {
                            Mooving = true;
                            Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                            Player.transform.position = Player.transform.position + new Vector3(0.03f, -0.08f, 0);
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
                            Player.transform.position = Player.transform.position + new Vector3(0.07f, -0.15f, 0);
                            //Debug.Log("Space D.");
                        }

                    }
                }


                if (Input.GetKeyDown(KeyCode.UpArrow) && Mooving == false)
                {
                    GrowSound.Play(
                        );
                    if (Etape3 == true)
                    {

                        Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(0.2f, random, 0);
                        //Debug.Log("SUUUUUUUUUUUUUUUUU.");
                        Etape2 = false;
                    }
                    if (Etape2 == true)
                    {

                        Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(0.15f, random , 0);
                        //Debug.Log("SUUUUUUUUUUUUUUioioioiUUU.");
                        //Etape2 = false;
                    }
                    if (Obstacle1 == true)
                    {
                        Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(0.03f, random , 0);
                        //Debug.Log("Space key was pressed.");
                    }
                    else
                    {
                        Instantiate(Arbre, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(0.09f, random , 0);
                        //Debug.Log("Space key was pressed.");
                    }
                }
            }
        }


        if (END)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Noyau.transform.localScale = Noyau.transform.localScale + new Vector3(0.05f, 0.05f, 0.05f);
                endCount = endCount + 1;

            }

            if (endCount >= 30)
            {
                //Noyau.GetComponent<MeshRenderer>().material = Material1P2;
                Explosion.SetActive(true);
                StartCoroutine(Attendre());
            }

        }

        /* if (END == true)
         {
             Debug.Log("OOOOOOOOOOOOOO");
             EndSound.Play();
             WooshSound.Play();
             GameOverCanva.SetActive(true);
         }*/




        Mooving = false;



        /*if (Player.transform.position.y >= 0)
        {
            //Debug.Log("GameOver");
            //GameOver.SetActive(true);
            EndSound.Play();
            WooshSound.Play();
            GameOverCanva.SetActive(true);
        }*/

    }

    private IEnumerator Attendre()
    {
        yield return new WaitForSeconds(2);
        WooshSound.Play();
        GameOverCanva.SetActive(true);
        Score.text = "Player 3 Winner";
        Player.SetActive(false);
        PLAYER1.SetActive(false);
        PLAYER2.SetActive(false);
        PLAYER3.SetActive(false);
    }
}
