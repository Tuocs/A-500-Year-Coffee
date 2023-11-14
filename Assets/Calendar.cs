using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Calendar : MonoBehaviour
{
    [SerializeField] private int targetScene;
    public void Activate()
    {
        SceneManager.LoadScene(targetScene);
    }
}

