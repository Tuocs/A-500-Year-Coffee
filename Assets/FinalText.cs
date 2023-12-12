using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalText : MonoBehaviour
{
    public TMP_Text text;
    // Update is called once per frame
    void Update()
    {
        text.text = "it has been\n" + Mathf.RoundToInt(Time.time - GameManager.startTime) + "\nSeconds";
    }
}
