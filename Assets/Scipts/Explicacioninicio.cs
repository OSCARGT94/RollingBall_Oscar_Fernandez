using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explicacioninicio : MonoBehaviour
{
    [SerializeField] GameObject avisoInicio;
    // Start is called before the first frame update
    void Start()
    {
        avisoInicio.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            avisoInicio.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            avisoInicio.SetActive(false);
        }
    }
}
