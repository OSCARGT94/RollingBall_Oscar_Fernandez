using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformaMovil : MonoBehaviour
{
    [SerializeField] Vector3 movimiento;
    [SerializeField] float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movimiento.normalized * velocidad * Time.deltaTime);
    }
}
