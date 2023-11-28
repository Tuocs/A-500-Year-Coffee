using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walet : MonoBehaviour
{
    [SerializeField] private GameObject money;

    public void Activate()
    {
        GameObject go = Instantiate(money);
    }
}
