using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class selectMission : MonoBehaviour
{
    public GameObject mission1;
    public GameObject mission2;
    public GameObject backbtn;
    public GameObject newgamebtn;
    public GameObject instructionsbtn;
    public GameObject exitbtn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SelectMissionbtn()
    {
        mission1.SetActive(true);
        mission2.SetActive(true);
        backbtn.SetActive(true);
        newgamebtn.SetActive(false);
        exitbtn.SetActive(false);
        instructionsbtn.SetActive(false);
    }
}
