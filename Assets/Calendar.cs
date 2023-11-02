using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Calendar : MonoBehaviour
{
    public void Activate()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
