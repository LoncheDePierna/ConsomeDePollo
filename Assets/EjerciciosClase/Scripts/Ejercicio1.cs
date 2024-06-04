using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    public float number1, number2;
    public float[] numbers;
    private float[] pNumbers = { 1f, 2f, 3f, 4f, 5f };
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Numero 1: " + number1 + " Numero 2: " + number2);
        Debug.Log("suma: " + Add(number1, number2));
        Debug.Log("multiplicacion: " + Multiply(number1, number2));
        Debug.Log("Sumatoria del arreglo publico es: " + Summation(numbers));
        Debug.Log("Sumatoria del arreglo priado es: "+ Summation(pNumbers));
    }

    float Add(float _number1, float _number2)
    {
        return _number1 + _number2;
    }

    float Multiply(float _number1, float _number2)
    {
        return _number1 * _number2;
    }

    float Summation(float[] _array)
    {
        float _summation = 0f;
            for (int i = 0; i < _array.Length; i++)
        {
            _summation += _array[i];
        }
        /*
        foreach (float _number in _array)
        {
            _summation += _number;
        }
        */
        return _summation;
    }

}