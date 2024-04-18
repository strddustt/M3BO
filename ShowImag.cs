using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowImag : MonoBehaviour
{
    private Canvas Imag;


    void Start()
    {
        Imag = GetComponent<Canvas>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Imag.enabled = true;
    }
}
