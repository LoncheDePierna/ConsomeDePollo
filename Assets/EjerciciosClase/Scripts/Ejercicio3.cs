using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    // Variables publicas
    public GameObject myLight;
    public Light myLightComponent;
    private bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        SwichtLight();
    }

    void SwichtLight()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isOn)
            {
                //myLight.GetComponent<Light>().enabled = false;
                //myLight.GetComponent<Light>().intensity = 0f;
                myLightComponent.enabled = false;
                isOn = false;
            }
            else
            {
                //myLight.GetComponent<Light>().enabled = true;
                //myLight.GetComponent<Light>().intensity = 1f;
                myLightComponent.enabled = true;
                isOn = true;
            }
        }
    
    }

}

