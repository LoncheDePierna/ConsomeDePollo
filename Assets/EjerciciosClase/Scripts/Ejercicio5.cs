using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Ejercicio5 : MonoBehaviour
{
    public UnityEvent OnAppear;

    [SerializeField] private float timeToBegin;
    [SerializeField] private GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Begin());
    }

    IEnumerator Begin()
    {
        Debug.Log("Empezando en: " +  timeToBegin + " segundos");
        yield return new WaitForSeconds(timeToBegin);
        StartCoroutine(Appear());
    }

    IEnumerator Appear()
    {
        for (float _alpha = 0f; _alpha <= 1f; _alpha += 1f * Time.deltaTime)
        {
            Color _c = cube.GetComponent<Renderer>().material.color;
            _c.a = _alpha;
            cube.GetComponent<Renderer>().material.color = _c;
            yield return null;
        }
        OnAppear.Invoke();
    }
    
}
