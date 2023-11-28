using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private tutorial tutorial;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Money")
        {
            tutorial.PhaseThree();
        }
    }
}
