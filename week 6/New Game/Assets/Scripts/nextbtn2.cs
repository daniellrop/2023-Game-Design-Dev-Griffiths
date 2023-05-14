using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextbtn2 : MonoBehaviour
{
    public GameObject ready;
    public GameObject nextbtntwo;
    public GameObject thirdText;
    
    public GameObject firsttext;
    public GameObject secondText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextButton()
    {
        ready.SetActive(true);
        nextbtntwo.SetActive(false);
        thirdText.SetActive(true);
        firsttext.SetActive(false);
        secondText.SetActive(false);
        
    }
    
}
