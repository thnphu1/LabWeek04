using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    private int i = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string gameObjectName = gameObject.name;
        Debug.Log($"{gameObjectName}:{i}");
        i++;

    }
}
