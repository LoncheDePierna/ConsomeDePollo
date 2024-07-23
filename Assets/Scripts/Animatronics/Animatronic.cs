using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatronicos : MonoBehaviour
{
    //variables publicas
    public float timeToMove, probabilityOfMoving;
    public GameObject[] positions;
    public Door door;

    public GameObject jumpscareMesh;

    //variables privada
    private int positionIndex;

    // Start is called before the first frame update
    void Start()
    {
        //inicalizacion
        positionIndex = 0;
        StartCoroutine(MovementCorrutine(Random.Range(timeToMove - 5f, timeToMove + 5f)));
    }
  
    //funcion de movimiento
    void move()
    {
        //Calcular probabilidad para moverse
        if (Random.Range(0f, 100f) <= probabilityOfMoving)
        {
            //Verificamos si estamos ne la puerta
            if (positionIndex == positions.Length - 1)
            {
                //verificamos que la puerta este abierta
                if (door == null || door.IsOpen())
                {
                    //atacamos
                    StopAllCoroutines();
                    attack();
                    return;
                }
                else
                {
                    positionIndex = 0;
                    positions[positionIndex].SetActive(true);
                }
            }
            else
            {
                positions[positionIndex].SetActive(false);
                positionIndex++;
                positions[positionIndex].SetActive(true);
            }
        }
        //inicamos la corrutina para le siguiente movimiento
        StartCoroutine(MovementCorrutine(Random.Range(timeToMove - 5f, timeToMove + 5f)));
    }

    //corrutina attack
    public void attack()
    {
        jumpscareMesh.SetActive(true);
        LevelManager.Instance.PlayerDead();
    }

    //corrutina de movimeinto
    IEnumerator MovementCorrutine(float time)
    {
        //Esperamos el timepo para hacer un movimiento
        yield return new WaitForSeconds(time);

        //intentamos movernos
        move();
    }
}