using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbtntitlemenu : MonoBehaviour
{
    public GameObject mission1;
    public GameObject mission2;
    public GameObject backbtn;
    public GameObject newgamebtn;
    public GameObject instructionsbtn;
    public GameObject exitbtn;
    public GameObject selectmission;
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
        mission1.SetActive(false);
        mission2.SetActive(false);
        backbtn.SetActive(false);
        newgamebtn.SetActive(true);
        instructionsbtn.SetActive(true);
        exitbtn.SetActive(true);
        selectmission.SetActive(true);
    }
}
