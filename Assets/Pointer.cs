using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    [SerializeField] private Transform lookTarget;
    [SerializeField] private Transform followTarget;
    [SerializeField] private Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(lookTarget);
        transform.position = followTarget.position + offset;
    }
}
