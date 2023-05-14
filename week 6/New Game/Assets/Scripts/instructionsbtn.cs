using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructionsbtn : MonoBehaviour
{
    public GameObject instructionText;
    public GameObject instructionbtn;
    public GameObject backbtn;
    public GameObject newgamebtn;
    public GameObject selectMission;

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
        newgamebtn.SetActive(false);
        selectMission.SetActive(false);
    }
}
