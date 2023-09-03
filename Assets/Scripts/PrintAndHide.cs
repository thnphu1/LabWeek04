using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int a = 3;

    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string gameObjectName = gameObject.name;
        Debug.Log($"{gameObjectName}:{a}");
        a++;

    }
}
