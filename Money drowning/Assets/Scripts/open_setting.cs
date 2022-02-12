using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_setting : MonoBehaviour
{
    GameObject p_setting;
    GameObject b_start;
    GameObject b_setting;

    // Start is called before the first frame update
    void Start()
    {
        b_start = GameObject.FindWithTag("Start_button");
        b_setting = GameObject.FindWithTag("Setting_button");
        p_setting = GameObject.FindWithTag("Setting_pannel");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void open_setting_pannel() 
    {
        b_start.SetActive(false);
        b_setting.SetActive(false);
        p_setting.SetActive(true);
    }
}