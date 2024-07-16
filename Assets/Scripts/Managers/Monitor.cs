using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Monitor : MonoBehaviour
{
    // Variables Publicas
    public GameObject camerasPanel;
    public GameObject[] cameras;

    public AudioSource monitorAS, buttomAS;

    // Variables Privadas
    private int currentCamera;


    // Singleton
    public static Monitor Instance { get; private set; }

    private void Awake()
    {
        // Verificacion del singleton
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Inicializacion de variables
        currentCamera = 0;

    }

    // Funcion para activar camara
    public void EnableCamera(int _index)
    {
        // Desactivamos la camara actual y activamos la nueva camara
        cameras[currentCamera].SetActive(false);
        cameras[_index].SetActive(true);
        currentCamera = _index;
        buttomAS.Play();

        // Si la camara es donde esta la music box, activamos su UI
        if (currentCamera == 7)
        {
            MusicBox.Instance.SetStateUI(true);
        }
        else
        {
            MusicBox.Instance.SetStateUI(false);
        }
    }

    // Funcion para cambiar el estado del monitor

    public void SetIsActive(bool _state)
    {
        cameras[currentCamera].SetActive(_state);
        camerasPanel.SetActive(_state);
        if (_state)
        {
            monitorAS.Play();
            EnergyManager.Instance.IncreaseConsumptionLevel();
        }
        else
        {
            monitorAS.Stop();
            EnergyManager.Instance.DecreaseConsumptionLevel();
        }

        // Musicbox
        if (currentCamera == 7)
        {
            MusicBox.Instance.SetStateUI(_state);
        }
    }

}
