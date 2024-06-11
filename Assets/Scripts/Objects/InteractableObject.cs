using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractableObject : MonoBehaviour
{
    // Variables publicas
    public UnityEvent OnInteract;

    // Funcion de interaccion
    public void Interact()
    {
        // Activar el evento
        OnInteract.Invoke();
    }
}
