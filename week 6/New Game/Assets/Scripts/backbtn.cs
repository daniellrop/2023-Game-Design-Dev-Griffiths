using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbtn : MonoBehaviour
{
    public GameObject newgamebtn;
    public GameObject exit;
    public GameObject instructions;
    public GameObject back;
    public GameObject instructionstext;
    public GameObject selectMission;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BackButton()
    {
        newgamebtn.SetActive(true);
        exit.SetActive(true);
        instructions.SetActive(true);
        instructionstext.SetActive(false);
        back.SetActive(false);
        selectMission.SetActive(true);
    }
}
