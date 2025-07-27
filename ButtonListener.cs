using UnityEngine;
using System.Collections;
using System.Collections.Generic;
// arstarst

public class ButtonListener : MonoBehaviour
{
    public void OnClickButton(){
        Debug.Log("you just pressed button and this called from Debug.Log");
        print("you just pressed button and this called from print");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
