using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen;
    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isOpen = true;
        UpdateAnimation();
    }

    // Funcion para cambiar estado de la puerta
    public void SetIsOpen(bool _state) 
    {
        isOpen = _state;
        UpdateAnimation();
    }

    // Funcion para regresar estado de la puerta
    public bool IsOpen(bool _state)
    {
        return isOpen;
    }
    // Funcion para actualizar el estado de la puerta
    public void UpdateAnimation()
    {
        animator.SetBool("isOpen", isOpen);
    }
}

