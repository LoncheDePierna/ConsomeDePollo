using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotation : MonoBehaviour
{
    // Variables publicas
    public float rotationLimit, rotationSpeed;

    //Variables privadas
    private float originalYrotation, yRotation;
    private int orientation;


    // Start is called before the first frame update
    void Start()
    {
        originalYrotation = transform.localEulerAngles.y;
        yRotation = transform.localEulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        Rotation();
    }
    // Funcion para rotar
    void Rotation()
    {
        // Si llegamos a alguno de los limited entonces cambiamos la orientacion
        if ((transform.localEulerAngles.y <= originalYrotation - rotationLimit) || (transform.localEulerAngles.y >= originalYrotation + rotationLimit))
        {
            ChangeRotation();
        }


        // Rotamos
        yRotation += rotationSpeed * orientation * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(transform.localEulerAngles.x, yRotation, transform.localEulerAngles.z);


    }

    // Funcion para cambiar la orientacion
    void ChangeRotation()
    {
        orientation *= -1;
    }

}

