using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ejercicio2 : MonoBehaviour
{
    //Variables privadas
    [SerializeField] private int firstNumber, lastNumber, loop;

    // Start is called before the first frame update
    void Start()
    {
        switch (loop)
        {
            case 1:
                UsingForLoop();
                break;

            case 2:
                UsingWhileLoop();
                break;
            case 3:
                StartCoroutine(OnePerSecond());
                break;
            case 4:
                StartCoroutine(OnePerFrame());
                break;
            default:
                Debug.Log("Numero Invalido");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UsingForLoop()
    {
        for (int i = firstNumber; i < lastNumber; i++)
        {
            Debug.Log(i);
            if (i == (int)Mathf.Lerp(firstNumber, lastNumber, 0.5f))
            {
                Debug.Log("Mitad del camino");
            }
        }
        Debug.Log("Terminado con un ciclo for");
    }

    IEnumerator OnePerSecond()
    {
        for (int i = firstNumber; i < lastNumber; i++)
        {
            Debug.Log(i);
            if (i == (int)Mathf.Lerp(firstNumber, lastNumber, 0.5f))
            {
                Debug.Log("Mitad del camino");
            }
            yield return new WaitForSeconds(1f);
        }
        Debug.Log("Terminado con un ciclo for por segundo");
    }

    IEnumerator OnePerFrame()
    {
        for (int i = firstNumber; i < lastNumber; i++)
        {
            Debug.Log(i);
            if (i == (int)Mathf.Lerp(firstNumber, lastNumber, 0.5f))
            {
                Debug.Log("Mitad del camino");
            }
            yield return null;
        }
        Debug.Log("Terminado con un ciclo for frame");
    }
    void UsingWhileLoop()
    {
        int _index = firstNumber;
        while (_index <= lastNumber) 
        {
            Debug.Log(_index);
            if (_index == (int)Mathf.Lerp(firstNumber, lastNumber, 0.5f))
            {
                Debug.Log("Mitad del camino");
            }
            _index++;
        }
        Debug.Log("Terminado con un ciclo while");
    }

}
