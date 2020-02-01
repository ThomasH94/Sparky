using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class wil be responsible for updating the UI of the player health
/// </summary>
public class FillStatusBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    #region UI
    public Image fillImage;
    public Slider barSlider;
    private float fillValue = 0;
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        UpdateHealthSlider();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            Heal();
        }

        if(Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage();
        }
    }

    // Updates our slider values based on the amount of health remaining and disables the
    // fill image if we are less than a minimum threshold - defined in the inspector
    private void UpdateHealthSlider()
    {
        float lowHealthRange = barSlider.maxValue / 3;  // Three is arbitrary for a "low" health threshold
        if(barSlider.value <= barSlider.minValue)
        {
            fillImage.enabled = false;
        }
        else
        {
            if(fillImage.enabled == false)
            {
                fillImage.enabled = true;
            }
        }

        fillValue = playerHealth.currentHealth / playerHealth.maxHealth;
        /*  UNCOMMENT IF YOU WANT HEALTH TO CHANGE COLORS - can be expanded for multiple phases
        if(fillValue <= lowHealthRange)
        {
            fillImage.Color = Color.white;  // Or any color for that matter..
        }
        else if(fillValue > lowHealthRange)
        {
            fillImage.Color = Color.green; // Sets our color back to default
        }
        */

        barSlider.value = fillValue;

    }

    private void Heal()
    {
        playerHealth.currentHealth++;
        if(playerHealth.currentHealth > playerHealth.maxHealth)
        {
            playerHealth.currentHealth = playerHealth.maxHealth;
        }
        UpdateHealthSlider();
    }

    private void TakeDamage()
    {
        playerHealth.currentHealth--;
        
        if(playerHealth.currentHealth < playerHealth.minHealth)
        {
            playerHealth.currentHealth = playerHealth.minHealth;
        }
        UpdateHealthSlider();
    }
}
