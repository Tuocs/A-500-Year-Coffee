using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalText : MonoBehaviour
{
    public TMP_Text text;
    // Update is called once per frame

    private void Start()
    {
        text.text = "you have been playing this game for\n" + 
            Mathf.RoundToInt(Time.time - GameManager.startTime + 120) + " Seconds\n " +
            "but if your cup was paper it would have only lasted " + 
            ((Time.time - GameManager.startTime + 120) * 0.00015331956f);
    }
    void Update()
    {
        //text.text = "you have been playing this game for\n" + Mathf.RoundToInt(Time.time - GameManager.startTime) + "\nSeconds\n but if your cup was paper it would have only lasted " + Mathf.Round(Time.time - GameManager.startTime);
    }
}
