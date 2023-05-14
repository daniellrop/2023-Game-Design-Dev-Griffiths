using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextTextbtn : MonoBehaviour
{

    public GameObject secondText;
    public GameObject nextbtn;
    public GameObject nextbtn2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextText()
    {
        secondText.SetActive(true);
        nextbtn.SetActive(false);
        nextbtn2.SetActive(true);
    }
}
