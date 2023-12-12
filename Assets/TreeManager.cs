using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

[ExecuteInEditMode]
public class TreeManager : MonoBehaviour
{
    
    public GameObject[] trees;
    public int growth;
    public int type;
    public int sceneGrowth;
    public bool generateNew;
    void OnEnable()
    {
        if (generateNew)
        {
            growth = Random.Range(0, 3);
            type = Random.Range(0, 2);
            generateNew = false;
        }
        foreach (var tree in trees) { tree.SetActive(false); }

        int totalGrowth = (growth+sceneGrowth) % 4;
        if (totalGrowth == 0)
        {
            trees[0].SetActive(true);
        }
        else if (totalGrowth == 3)
        {
            trees[Random.Range(5,13)].SetActive(true);
        }
        else if (type == 0)
        {
            trees[0 + totalGrowth].SetActive(true);
        }
        else if(type == 1)
        {
            trees[2 + totalGrowth].SetActive(true);
        }
        
    }
}
