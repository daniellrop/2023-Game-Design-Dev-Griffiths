using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerControlLevel2 : MonoBehaviour
{
    //Player related
    public GameObject Player;
    public ParticleSystem ps;
    public float playerPower;
    public float turnPower;
    public float playerBreak;
    public GameObject breakfire;
    public GameObject sidefire;
    public GameObject sidefire2;
    public GameObject sidefire3;
    public GameObject sidefire4;
    public AudioSource rocket;


    //Game Related
    bool gameOver = false;
    bool gameFinished = false;
    public GameObject finishedGame;
    public GameObject restartbtn;
    public GameObject closeGame;
    public GameObject instructionsbtn;
    public GameObject backbtn;
    public GameObject titlemenu;
    public GameObject resumebtn;
    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerAcceleration();
        PlayerBreakReverse();
        PlayerRotation();
        GamePause();
    }

    void PlayerAcceleration()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && gameOver == false && gameFinished == false)
        {
            GetComponent<Rigidbody>().AddForce(transform.up * playerPower, ForceMode.Impulse);
            ps.Play();

        }
        else
        {
            ps.Stop();
        }
        if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && gameOver == false)
        {
            rocket.Play();
        }
        if ((Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow)) && gameOver == false)
        {
            rocket.Stop();
        }
    }
    void PlayerBreakReverse()
    {
        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && gameOver == false && gameFinished == false)
        {
            GetComponent<Rigidbody>().AddForce(transform.up * playerBreak, ForceMode.Impulse);
            breakfire.SetActive(true);
        }
        else
        {
            breakfire.SetActive(false);
        }
    }
    void PlayerRotation()
    {
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && gameOver == false && gameFinished == false)
        {
            GetComponent<Rigidbody>().AddTorque(Vector3.back * turnPower, ForceMode.Impulse);
            sidefire.SetActive(true);
            sidefire4.SetActive(true);
        }
        else
        {
            sidefire.SetActive(false);
            sidefire4.SetActive(false);
        }
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && gameOver == false && gameFinished == false)
        {
            GetComponent<Rigidbody>().AddTorque(Vector3.forward * turnPower, ForceMode.Impulse);
            sidefire2.SetActive(true);
            sidefire3.SetActive(true);
        }
        else
        {
            sidefire2.SetActive(false);
            sidefire3.SetActive(false);
        }
    }
    void GamePause()
    {
        if (Input.GetKey(KeyCode.Escape) && gameOver == false && gameFinished == false)
        {
            instructionsbtn.SetActive(true);
            closeGame.SetActive(true);
            titlemenu.SetActive(true);
            resumebtn.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Walls" || collision.gameObject.tag == "Objects")
            {
            gameOver = true;
            gameOverScreen.SetActive(true);
            closeGame.SetActive(true);
            restartbtn.SetActive(true);
            GetComponent<Rigidbody>().isKinematic = true;
            rocket.Stop();
            //instructionsbtn.SetActive(true);
        }
        else if (collision.gameObject.name == "winpoint")
        {
            gameFinished = true;
            finishedGame.SetActive(true);
            titlemenu.SetActive(true);
            closeGame.SetActive(true);
            GetComponent<Rigidbody>().isKinematic = true;
            Player.SetActive(false);
            rocket.Stop();

        }
    }
}
