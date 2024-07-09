using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour
{
    //Variables publicas
    public float rotationLimit, RotationSpeed;

    //Variables privadas 
    private float originalYrotation, yRotation;
    private int orientation;

    void Start()
    {
        //Inicalizacion de variables
        originalYrotation = transform.localEulerAngles.y;
        yRotation = transform.localEulerAngles.y;
        orientation = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }

    //Funcion para rotar
    void Rotation()
    {

        //Si llegamos a alguno de los limites de la rotacion entonces cambiamos la orientacion
        if ((transform.localEulerAngles.y <= originalYrotation - rotationLimit) || (transform.localEulerAngles.y >= originalYrotation + rotationLimit))
        {
            ChangeRotation();
        }

        //Rotamos
        yRotation += RotationSpeed * orientation * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(transform.localEulerAngles.x, yRotation, transform.localEulerAngles.z);
    }

    //Funcion para cambiar la orientacion
    void ChangeRotation()
    {
        orientation *= -1;
    }
}