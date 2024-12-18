using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolverACamaraArriba : MonoBehaviour
{
    [SerializeField] AudioClip sonidoDescubrir;
    [SerializeField] AudioManager audioManager;
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
            camara1.SetActive(false);

            camaCenital.SetActive(true);

            camaraLateral.SetActive(false);

        }
        if (other.CompareTag("Player"))
        {
            audioManager.ReproducirSonido(sonidoDescubrir);
        }
    }
}
