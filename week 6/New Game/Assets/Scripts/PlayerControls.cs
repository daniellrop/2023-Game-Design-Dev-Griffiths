using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour
{
    public float playerJumpForce;
    public float playerTurnForce;
    public float playerBreakForce;
    public bool gameOver = false;
    public bool gameFinished = false;


    public GameObject cube;
    public GameObject cube2;
    public GameObject cube3;
    public GameObject cube4;
    public GameObject cube5;
    public GameObject cube6;
    public GameObject cube7;
    public GameObject cube8;



    public GameObject gameOverScreen;
    public GameObject sidefire;
    public GameObject sidefire2;
    public GameObject sidefire3;
    public GameObject sidefire4;
    public GameObject breakfire;


    //public GameObject startGameScreen;
    public GameObject proceed1;
    public GameObject finishedGame;
    public GameObject restartbtn;
    public GameObject closeGame;
    public GameObject instructionsbtn;
    public GameObject backbtn;
    public GameObject titlemenu;
    public GameObject resumebtn;
    public GameObject nextLevel;



    public GameObject fuel1;
    public GameObject fuel2;
    public GameObject fuel3;
    public GameObject fuel4;
    public GameObject fuel5;
    public GameObject fuel6;
    public GameObject fuel7;

    public ParticleSystem ps;
    public AudioSource rocket;
    
    void Start()
    {
       
    }

    void Update()
    {
        ForwardMovePlayer();
        RotationPlayer();
        BreakReversePlayer();
        GamePause();
    }
    private void ForwardMovePlayer()

    {
        if (GetComponent<Rigidbody>().useGravity == false && Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().useGravity = true;
        }

        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && gameOver == false && gameFinished == false)
        {
            GetComponent<Rigidbody>().AddForce(transform.up * playerJumpForce, ForceMode.Impulse);
            //startGameScreen.SetActive(false);
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

    void RotationPlayer()
    {
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && gameOver == false && gameFinished == false)
        {
            GetComponent<Rigidbody>().AddTorque(Vector3.back * playerTurnForce, ForceMode.Impulse);
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
            GetComponent<Rigidbody>().AddTorque(Vector3.forward * playerTurnForce, ForceMode.Impulse);
            sidefire2.SetActive(true);
            sidefire3.SetActive(true);
        }
        else
        {
            sidefire2.SetActive(false);
            sidefire3.SetActive(false);
        }
    }
    void BreakReversePlayer()
    {
        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && gameOver == false && gameFinished == false)
        {
            GetComponent<Rigidbody>().AddForce(transform.up * playerBreakForce, ForceMode.Impulse);
            breakfire.SetActive(true);
        }
        else
        {
            breakfire.SetActive(false);
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

        if (collision.gameObject.tag == "cube" && gameFinished == false)
        {
            gameOver = true;
            print("Hit!");
            gameOverScreen.SetActive(true);
            GetComponent<Rigidbody>().isKinematic = true;
            restartbtn.SetActive(true);
            closeGame.SetActive(true);
            

        }
        if (collision.gameObject.tag == "fuel1")
        {
            fuel1.SetActive(false);
            //proceed1.SetActive(true);
            fuel2.SetActive(true);
        }
        
        if (collision.gameObject.tag == "fuel2")
        {
            
            fuel2.SetActive(false);
            fuel3.SetActive(true);
            //proceed1.SetActive(true);
        }
        if (collision.gameObject.tag == "fuel3")
            {
                fuel3.SetActive(false);
                fuel4.SetActive(true);
            }
            if (collision.gameObject.tag == "fuel4")
            {
                fuel4.SetActive(false);
                fuel5.SetActive(true);
            }
            if (collision.gameObject.tag == "fuel5")
            {
                fuel5.SetActive(false);
                fuel6.SetActive(true);
            }
            if (collision.gameObject.tag == "fuel6")
            {
                fuel6.SetActive(false);
                fuel7.SetActive(true);
            }
            if (collision.gameObject.tag == "fuel7")
            {
                fuel7.SetActive(false);
            gameFinished = true;
            finishedGame.SetActive(true);
            GetComponent<Rigidbody>().isKinematic = true;
            //restartbtn.SetActive(true);
            //closeGame.SetActive(true);
            nextLevel.SetActive(true);

        }
        rocket.Stop();

        }
        }
