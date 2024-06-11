using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BottomComponent : MonoBehaviour
{
    // Variables publicas
    public Material materialOff, materialOn, materialDisable;
    public UnityEvent OnActivated, OnDesactivated;

    // Variables privadas
    private bool buttomState;
    private MeshRenderer meshRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        buttomState = false;
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = materialOff;
    }

    public void Swicht()
    {
        // Si el boton esta encendido    
        if (buttomState)
        {
            // Lo apagamos
            buttomState = false;
            meshRenderer.material = materialOff;
            OnDesactivated.Invoke();
        }
        // Si esta apagado
        else
        {
            // Lo encendemos
            buttomState = true;
            meshRenderer.material = materialOn;
            OnActivated.Invoke();

        }
    }
}
