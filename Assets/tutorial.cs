using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private GameObject Cup;
    private int phase = 1;
    public void PhaseTwo()
    {
        if (phase != 1) { return; }
        phase = 2;
        text.text = "Now activate the walet by pressing the trigger to drop money on the counter for a coffee";
    }
    public void PhaseThree()
    {
        if (phase != 2) { return; }
        phase = 3;
        Cup.SetActive(true);
        text.text = "Now grab and enjoy your coffee, be carefull not to drop it carelessly";
    }
}