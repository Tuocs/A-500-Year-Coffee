using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Phone : MonoBehaviour
{
    [SerializeField] private TMP_Text display;
    [SerializeField] private string[] blerbs;
    private int count;

    public void Activate()
    {
        if (count >= blerbs.Length)
        {
            Close();
            count = 0;
            return;
        }
        display.text = blerbs[count];
        display.transform.parent.gameObject.SetActive(true);
        count++;
    }
    public void Close()
    {
        display.transform.parent.gameObject.SetActive(false);
    }
}
