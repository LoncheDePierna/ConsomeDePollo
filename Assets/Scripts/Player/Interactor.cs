using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    // Funcion de interaccion
    public void Interaction()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Creamos un rayo desde la camara hacia la posicion del cursor
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit _hit;
            if (Physics.Raycast(ray, out _hit, 100))
            {
                // Si el objeto tiene el componente de interaccion
                if (_hit.transform.gameObject.GetComponent<InteractableObject>() != null) 
                {
                    // Interactuamos con el objeto
                    _hit.transform.gameObject.GetComponent<InteractableObject>().Interact();
                }
            } 
        }
    }
}
