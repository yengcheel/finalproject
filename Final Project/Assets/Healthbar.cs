using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    private void Start()
    {
        _healthSlider = GetComponent<Slider>();
    }
    Slider _healthSlider;
    public void SetMaxHealth(int maxHealth)
    {
        _healthSlider.maxValue = maxHealth;
        _healthSlider.value = maxHealth;
    }
    public void SetHealth(int health)
    {
        _healthSlider.value = health;

    }
}
