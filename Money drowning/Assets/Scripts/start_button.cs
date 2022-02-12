using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class start_button : MonoBehaviour
{
    GameObject b_start;  
    // Start is called before the first frame update
    void Start()
    {
        b_start = GameObject.Find("B_Start");
        b_start.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
