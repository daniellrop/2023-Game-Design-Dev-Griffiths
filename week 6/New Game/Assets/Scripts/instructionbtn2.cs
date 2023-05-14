using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionbtn2 : MonoBehaviour
{
    public GameObject instructionText;
    public GameObject instructionbtn;
    public GameObject backbtn;
    public GameObject titlebtn;
    public GameObject exitbtn;
    public GameObject resumebtn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Instructions()
    {
        instructionbtn.SetActive(false);
        instructionText.SetActive(true);
        backbtn.SetActive(true);
        titlebtn.SetActive(false);
        resumebtn.SetActive(false);
        exitbtn.SetActive(false);
    }
}
