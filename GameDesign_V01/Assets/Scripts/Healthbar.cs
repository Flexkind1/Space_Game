using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// für User Interface
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    // momentaner Gesundheitsbalken
    public Image currentHealthbar;
    // Gesundheit als Zahl
    public Text ratioText;

    private float hitpoint = 150;
    private float maxHitpoint = 150;

    private void Start()
    {
        UpdateHealthbar();
    }

    private void UpdateHealthbar()
    {
        // Verhältnis von aktuellem Hitpoint und maximalen Hitpoint, zwischen 0 und 1
        // da Hitpoint nicht größer als max. Hitpoint sein kann. 
        float ratio = hitpoint / maxHitpoint;
        // Länge des momemanten Gesundheitzustandsbalken wird hier verändert
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        // Veränderung der Zahl
        // Verhältnis Hitpoint zu max. Hitpoint * 100 
        ratioText.text = (ratio * 100).ToString("0") + '%';
    }

    // Funktion Schaden bis Tod
    private void TakeDamage(float damage)
    {
        // hitpoint = hitpoint - damage 
        hitpoint -= damage;
        // Wenn der Hitpoint kleiner ist als 0
        if (hitpoint < 0)
        {
            // ist der Wert des Hitpoints 0
            hitpoint = 0;
            // und es wird die Nachricht "Dead" ausgesendet.
            Debug.Log("Dead!");
        }

        UpdateHealthbar();
        
    }

    // Funktion Heilung
    private void HealDamage(float heal)
    {
        // hitpoint = hitpoint + heal
        hitpoint += heal;
        // Wenn der Hitpoint größer ist als der maximale Hitpoint;
        if (hitpoint > maxHitpoint)
            // dann bestehen gleiche Werte bei hitpoint und maximalem Hitpoint.
            hitpoint = maxHitpoint;

        UpdateHealthbar();
    }

    
}
