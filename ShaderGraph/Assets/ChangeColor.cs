using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {

    [SerializeField] private Material material;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            material.SetColor("_Color", Color.green);
        }
        
        if (Input.GetKeyDown(KeyCode.V))
        {
            material.SetColor("_Color", Color.blue);
        }
    }
}
