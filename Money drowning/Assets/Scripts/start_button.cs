using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class start_button : MonoBehaviour
{
    GameObject b_start;
    GameObject b_setting;

    // Start is called before the first frame update
    void Start()
    {
        b_start = GameObject.FindWithTag("Start_button");
        b_setting = GameObject.FindWithTag("Setting_button");
    }
    // Update is called once per frame
    void Update()
    {
       
    }

    public void SetInactiveButton()
    {
        b_start.SetActive(false);
        b_setting.SetActive(false);
    }
    
}

