using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flicker : MonoBehaviour
{
    // Variables publicas
    public float minFlickInterval, maxFlickIterval;
    public float minLightIntensity;
    public float minFlickDuration, maxFlickDuration;

    // Variables privadas
    private Light lightComponent;
    private float intervalTime, originalLightIntensity;
    private float flickDuration;

    // Start is called before the first frame update
    void Start()
    {
        // Inicializacion de variables
        lightComponent = GetComponent<Light>();
        originalLightIntensity = lightComponent.intensity;
        intervalTime = Random.Range(minFlickInterval, maxFlickIterval);
    }

    // Update is called once per frame
    void Update()
    {
        Flick();
    }

    // Funcion de parpadeo
    void Flick()
    {
        // Si se acabo el intervalo de tiempo comenzamos el parpadeo
        if (intervalTime <= 0f)
        {
            //Atenuamos la luz, reseteamos el intervalo de tiempo y damos una duracion al parpadeo
            lightComponent.intensity = Random.Range(minLightIntensity, originalLightIntensity);
            intervalTime = Random.Range(minFlickInterval, maxFlickIterval);
            flickDuration = Random.Range(minFlickDuration, maxFlickDuration);
        }
        else
        {
            // Si aun queda tiempo de parpadeo, seguimos esperando
            if (flickDuration > 0f)
            {
                flickDuration -= 1f * Time.deltaTime;
            }
            else
            {
                flickDuration -= 1f * Time.deltaTime;
                lightComponent.intensity = originalLightIntensity;
            }
        }
    }

}

    