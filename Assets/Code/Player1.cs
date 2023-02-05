using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Player1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject PLAYER2;
    public GameObject Arbre1;
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

    public Material MatP1;
    public Material MatR1;
    public Material MatR2;
    public Material MatR3;
    public Material MatR4;

    public bool Mooving = false;
    public bool Obstacle1 ;
    public bool lave;
    public bool Etape2 = false;
    public bool Etape3 = false;
    public bool END = false;

    public TextMeshProUGUI Score;
    
    public float random;

    public float endCount;

    // je stocke en local l'id de larbre
    private int treeId;

    // Start is called before the first frame update
    void Start()
    {
        // ici je récupère l'index de l'arbre choisi par le J1 et je l'assigne à treeID
        treeId = PlayerPrefs.GetInt("ArbreJ1");
        Score = GameOverCanva.GetComponentInChildren<TextMeshProUGUI>();
        switch (treeId)
        {
            case 0:
                Baobab.SetActive(true);
                Cerisier.SetActive(false);
                Erable.SetActive(false);
                Sapin.SetActive(false);
                Arbre1.GetComponent<MeshRenderer>().material = MatR1;
                break;
            
            case 1:
                Cerisier.SetActive(true);
                Baobab.SetActive(false);
                Erable.SetActive(false);
                Sapin.SetActive(false);
                Arbre1.GetComponent<MeshRenderer>().material = MatR2;
                break;
            
            case 2:
                Erable.SetActive(true);
                Baobab.SetActive(false);
                Cerisier.SetActive(false);
                Sapin.SetActive(false);
                Arbre1.GetComponent<MeshRenderer>().material = MatR3;
                break;
            
            case 3:
                Sapin.SetActive(true);
                Baobab.SetActive(false);
                Cerisier.SetActive(false);
                Erable.SetActive(false);
                Arbre1.GetComponent<MeshRenderer>().material = MatR4;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            LoadScene();
        }




        random =Random.Range(-0.1f, 0.1f);



        if(lave == true)
        {
            Player.transform.position = new Vector3(0, 12.702f, 0);
            lave = false;

        }

        if (lave == false)
        {

            if (END == false)
            {
                if (Input.GetKey(KeyCode.Q))
                {
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        if (Obstacle1 == true)
                        {
                            Mooving = true;
                            Instantiate(Arbre1, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                            Player.transform.position = Player.transform.position + new Vector3(-0.08f, -0.03f, 0);
                            //Debug.Log("Space Q.");
                            Obstacle1 = false;
                        }
                        else
                        {
                            Mooving = true;
                            Instantiate(Arbre1, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                            Player.transform.position = Player.transform.position + new Vector3(-0.15f, -0.07f, 0);
                            //Debug.Log("Space Q.");
                        }

                    }
                }

                if (Input.GetKey(KeyCode.D))
                {
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        if (Obstacle1 == true)
                        {
                            Mooving = true;
                            Instantiate(Arbre1, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                            Player.transform.position = Player.transform.position + new Vector3(0.08f, -0.03f, 0);
                            //Debug.Log("Space D.");
                            Obstacle1 = false;
                        }
                        else
                        {
                            Mooving = true;
                            Instantiate(Arbre1, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                            Player.transform.position = Player.transform.position + new Vector3(0.15f, -0.07f, 0);
                            //Debug.Log("Space D.");
                        }

                    }
                }


                if (Input.GetKeyDown(KeyCode.Z) && Mooving == false)
                {
                    GrowSound.Play();
                    if (Etape3 == true)
                    {

                        Instantiate(Arbre1, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(random, -0.2f, 0);
                        //Debug.Log("SUUUUUUUUUUUUUUUUU.");
                        Etape2 = false;
                    }
                    if (Etape2 == true)
                    {

                        Instantiate(Arbre1, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(random, -0.15f, 0);
                        //Debug.Log("SUUUUUUUUUUUUUUioioioiUUU.");
                        //Etape2 = false;
                    }
                    if (Obstacle1 == true)
                    {
                        Instantiate(Arbre1, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(random, -0.03f, 0);
                        //Debug.Log("Space key was pressed.");
                    }
                    else
                    {
                        Instantiate(Arbre1, new Vector3(Player.transform.position.x, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
                        Player.transform.position = Player.transform.position + new Vector3(random, -0.09f, 0);
                        //Debug.Log("Space key was pressed.");
                    }
                }
            }

            Mooving = false;



            /* if (Player.transform.position.y <= 0)
             {

                 //Debug.Log("GameOver");
                 GameOver.SetActive(true);
                 EndSound.Play();
                 WooshSound.Play();
                 GameOverCanva.SetActive(true);
             }*/

            if (END)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    Noyau.transform.localScale = Noyau.transform.localScale + new Vector3(0.05f, 0.05f, 0.05f);
                    endCount = endCount + 1;

                }

                if (endCount >= 30)
                {
                    Noyau.GetComponent<MeshRenderer>().material = MatP1;
                    StartCoroutine(Attendre());
                    EndSound.Play();
                }

            }

        }
    }
    
    private IEnumerator Attendre()
    {
        yield return new WaitForSeconds(2);
        WooshSound.Play();
        GameOverCanva.SetActive(true);
        Score.text = "Player 1 Winner";
        Player.SetActive(false);
        Player.SetActive(false);
        PLAYER2.SetActive(false);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
