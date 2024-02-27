using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
public Transform jugador;
    public Transform objetivo; 

    public Vector3 offset; 
    public float velocidadRotacion = 3f; 

    private float inputHorizontal; 
    private float inputVertical; 
    void Update()
    {
        transform.position = jugador.position + offset;
        inputHorizontal = Input.GetAxis("Mouse X");
        inputVertical = Input.GetAxis("Mouse Y");

        if (Mathf.Abs(inputHorizontal) > 0)
        {
            float rotacionY = inputHorizontal * velocidadRotacion;

            transform.RotateAround(objetivo.position, Vector3.up, rotacionY);
        }
        if (Mathf.Abs(inputVertical) > 0)
        {
            float rotacionx = -inputVertical * velocidadRotacion;

            transform.RotateAround(objetivo.position, transform.right, rotacionx);
        
        Vector3 rotacionEuler = transform.eulerAngles;
        transform.eulerAngles = rotacionEuler;
        }
    }
}
