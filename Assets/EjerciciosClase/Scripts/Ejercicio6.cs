using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio6 : MonoBehaviour
{
    //Publicas
    public Transform cubo;
    public float velocidadDeRotacion;

    //Privadas
    private float rotacionY = 0;

    // Start is called before the first frame update
    void Start()
    {
        cubo.rotation = Quaternion.Euler(45f, 0f, 45f);
    }

    // Update is called once per frame
    void Update()
    {
        TransformPositionRotation(cubo.transform);
        Camera.main.transform.LookAt(cubo);
    }

    void TransformPositionRotation(Transform transform)
    {
        //transform.Rotate(new Vector3(0f, velocidadDeRotacionTime.deltaTime, 0f), Space.World);

        rotacionY += velocidadDeRotacion * Time.deltaTime;
        transform.rotation = Quaternion.Euler(new Vector3(transform.rotation.eulerAngles.x, rotacionY, transform.rotation.eulerAngles.z));
    }
}
