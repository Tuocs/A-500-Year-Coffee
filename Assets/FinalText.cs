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
        text.text = "If this cup were made of paper at the rate you were traveling through time, this game would have lasted less than a milisecond"; 
    }
    void Update()
    {
        //text.text = "you have been playing this game for\n" + Mathf.RoundToInt(Time.time - GameManager.startTime) + "\nSeconds\n but if your cup was paper it would have only lasted " + Mathf.Round(Time.time - GameManager.startTime);
    }
}
