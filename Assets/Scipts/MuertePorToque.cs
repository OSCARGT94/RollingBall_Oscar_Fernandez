using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuertePorToque : MonoBehaviour
{
    [SerializeField] GameObject camara1, camaCenital, camaraLateral;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            camara1.SetActive(true);

            camaCenital.SetActive(false);

            camaraLateral.SetActive(false);

        }
    }
}
