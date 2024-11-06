using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextosFlotantes : MonoBehaviour
{
    [SerializeField] GameObject textoLaberinto;
    [SerializeField] GameObject minimap;
    // Start is called before the first frame update
    void Start()
    {
        textoLaberinto.SetActive(false);
        minimap.SetActive(false);
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
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.K))
            {
                minimap.SetActive(true);
            }
            if (Input.GetKey(KeyCode.U))
            {
                minimap.SetActive(false);
            }
        }
    }
}
