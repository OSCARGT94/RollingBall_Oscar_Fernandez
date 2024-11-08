using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confeti : MonoBehaviour
{            
    ParticleSystem CONFETI;
    [SerializeField] AudioSource audiopop, audioMataSuegra;
    // Start is called before the first frame update
    void Start()
    {
        CONFETI = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CONFETI.Play();
        }
        if (other.CompareTag("Player"))
        {
           
            audiopop.Play();
            audioMataSuegra.Play();
        }
    }
}
