using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour
{
    // Variables Publicas
    public float energy, consumptionRate;
    public UnityEvent OnDischarged;

    public Image usageFiller;
    public TextMeshProUGUI powerLeftText;
   
    // Variables Privadas
    private int consumptionLevel;
    private bool isDischarged;

    // Singleton
    public static EnergyManager Instance { get; private set; }

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
        
        consumptionLevel = 0;
        isDischarged = false;
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        // Si no estamos descargados
        if (!isDischarged)
        {
            Consumption();
        }
    }

    void Consumption()
    {
        // Si aun tenemos energia seguimos descargando
        if (energy > 0f)
        {
            energy -= consumptionRate * consumptionLevel * Time.deltaTime;
            UpdateUI();
        }
        // Si ya no tenemos energuia
        else
        {
            UpdateUI();
            isDischarged = true;
            OnDischarged.Invoke();
        }
    }
    // Funcion para aumentar el nivel de consumo energetico
    public void IncreaseConsumptionLevel()
    {
        consumptionLevel++;
    }

    // Funcion para disminuir el nivel de consumo energetico
    public void DecreaseConsumptionLevel()
    {
        consumptionLevel--;
    }

    void UpdateUI()
    {
        powerLeftText.text = (int)energy + "%";
        usageFiller.fillAmount = consumptionLevel / 5f;
    }

}
