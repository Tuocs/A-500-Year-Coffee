using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private GameObject Cup;
    [SerializeField] private AudioSource Audio;

    private int phase = 1;

    void Start()
    {
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().StartTime();

    }

    public void PhaseTwo()
    {
        if (phase != 1) { return; }
        phase = 2;
        text.text = "Now activate the wallet by pressing the trigger to drop money on the counter for a coffee";
        Audio.Play();
    }
    public void PhaseThree()
    {
        if (phase != 2) { return; }
        phase = 3;
        Cup.SetActive(true);
        text.text = "Now grab and enjoy your coffee, be careful not to drop it carelessly";
        Audio.Play();
    }
}
