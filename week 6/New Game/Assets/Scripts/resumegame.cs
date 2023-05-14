using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resumegame : MonoBehaviour
{
    public GameObject resumebtn;
    public GameObject titlebtn;
    public GameObject exitbtn;
    public GameObject instructionsbtn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ResumeButton()
    {
        resumebtn.SetActive(false);
        titlebtn.SetActive(false);
        exitbtn.SetActive(false);
        instructionsbtn.SetActive(false);
        Time.timeScale = 1;
    }
}
