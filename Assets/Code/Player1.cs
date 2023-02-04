using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player1 : MonoBehaviour
{
    public GameObject Player;
    public GameObject Arbre1;

    public GameObject GameOver;

    public bool Mooving = false;

    public bool Obstacle1 ;
    public bool lave;
    public bool Etape2 = false;
    public bool Etape3 = false;
    public bool END = false;



    public float random;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }




        random =Random.Range(-0.1f, 0.1f);



        if(lave == true)
        {
            GameOver.SetActive(true);
            //lave = false;
            
        }

        if(lave == false)
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



        if(Player.transform.position.y <= 0)
        {
            //Debug.Log("GameOver");
            GameOver.SetActive(true);
        }

    }
}
