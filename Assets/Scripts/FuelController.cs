using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FuelController : MonoBehaviour
{
    public static FuelController instance;
    [SerializeField] private Image fuelImage;
    [SerializeField, Range(0.1f, 5f)] private float fuelDrainSpeed = 3f;
    [SerializeField] private float maxFuelAmount = 100f;
    [SerializeField] private Gradient fuelGradient;
    private float currentFuelAmount;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    private void Start()
    {
        currentFuelAmount = maxFuelAmount;
        UpdateUI();
    }
    private void Update()
    {
        currentFuelAmount -= Time.deltaTime * fuelDrainSpeed;
        UpdateUI();
        if (currentFuelAmount <= 0f)
        {
            Manager.instance.GameOver();
        }
    }
    private void UpdateUI()
    {
        fuelImage.fillAmount = (currentFuelAmount / maxFuelAmount);
        fuelImage.color = fuelGradient.Evaluate(fuelImage.fillAmount);
    }
    public void FillFuel()
    {
        currentFuelAmount = maxFuelAmount;
        UpdateUI();
    }
}
