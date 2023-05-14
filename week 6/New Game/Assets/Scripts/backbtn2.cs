using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backbtn2 : MonoBehaviour
{
    public GameObject tilemenu;
    public GameObject exit2;
    public GameObject instructions2;
    public GameObject back2;
    public GameObject instructionstext2;
    public GameObject resumebtn;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void BackButton2()
    {
        tilemenu.SetActive(true);
        exit2.SetActive(true);
        instructions2.SetActive(true);
        instructionstext2.SetActive(false);
        back2.SetActive(false);
        resumebtn.SetActive(true);
    }
}
