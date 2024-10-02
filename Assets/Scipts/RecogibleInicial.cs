using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogibleInicial : MonoBehaviour
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
        transform.Rotate (movimiento * velocidad * Time.deltaTime, Space.World);


    }
}
