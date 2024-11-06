using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextosFlotantes : MonoBehaviour
{
    [SerializeField] GameObject textoLaberinto;
    // Start is called before the first frame update
    void Start()
    {
        textoLaberinto.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textoLaberinto.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textoLaberinto.SetActive(false);
        }
    }
}
