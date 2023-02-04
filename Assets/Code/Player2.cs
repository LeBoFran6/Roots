using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player2 : MonoBehaviour
{
    public GameObject Player;
    public GameObject PLAYER1;
    public GameObject Arbre;

    public GameObject GameOver;

    public bool Mooving = false;

    public bool Obstacle1;
    public bool lave;
    public bool Etape2 = false;
    public bool Etape3 = false;

    public bool END = false;


    public float random;

    public GameObject Noyau;


    public float endCount = 0;

    public Material Material1P2;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        random = Random.Range(-0.1f, 0.1f);



        if (lave == true)
        {
            // GameOver.SetActive(true);
            Player.transform.position = new Vector3(0, -12.702f, 0);
            lave = false;

        }


        if (lave == false)
        {

            if (END == false)
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
                        }
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
                        }
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


        }




        Mooving = false;




        if(END)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Noyau.transform.localScale = Noyau.transform.localScale + new Vector3(0.05f, 0.05f, 0.05f);
                endCount = endCount + 1;
                
            }

            if (endCount >= 30)
            {
                Noyau.GetComponent<MeshRenderer>().material = Material1P2;
                Player.SetActive(false);
                PLAYER1.SetActive(false);
            }
        }










    }
}
