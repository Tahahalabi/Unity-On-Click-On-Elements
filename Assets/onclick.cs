using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onclick : MonoBehaviour
{
    //public Button btn1;

    //public Text text1;

    // Start is called before the first frame update
    void Start()
    {
       // btn1.onClick.AddListener(myFuntionOne);

       // text1.GetComponent<Button>().onClick.AddListener(myFuntionTwo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void myFuntionOne ()
    {
        Debug.Log("Button 1 clicked");
    }

    public void myFuntionTwo()
    {
        Debug.Log("Text 1 clicked");
    }
}
