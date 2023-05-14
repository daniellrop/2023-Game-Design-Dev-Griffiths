using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newGame : MonoBehaviour
{

    public GameObject Story;
    public GameObject NewGameButton;
    public GameObject Nextbtn;
    public GameObject instructionsbtn;
    public GameObject selectMission;
    

    //public GameObject Story2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void NewGame()
    {
        Story.SetActive(true);
        NewGameButton.SetActive(false);
        Nextbtn.SetActive(true);
        instructionsbtn.SetActive(false);
        selectMission.SetActive(false);
    }
    
}
