using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvisoCorrer : MonoBehaviour
{
    [SerializeField] GameObject avisoCorrer;
    // Start is called before the first frame update
    void Start()
    {
        avisoCorrer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            avisoCorrer.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            avisoCorrer.SetActive(false);
        }
    }
}
