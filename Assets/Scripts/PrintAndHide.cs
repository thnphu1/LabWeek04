using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int a = 3;
    private int randomValue;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        randomValue = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        string gameObjectName = gameObject.name;
        Debug.Log($"{gameObjectName}:{a+1}");
        a++;
        if (gameObject.CompareTag("Red") && a == 100)
        {
            // Deactivate the game object if it has the "Red" tag and i is 100.
            gameObject.SetActive(false);
        }
        else if (gameObject.CompareTag("Blue") && a == randomValue)
        {
            // Disable the Renderer component if it has the "Blue" tag and i matches the random value.
            rend = GetComponent<Renderer>();
            if (rend != null)
            {
                rend.enabled = false;
            }
        }
    }
}
