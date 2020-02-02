using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script will track all of the relevant information for completing the game and determining an ending
/// </summary>
public class QuestTracker : MonoBehaviour
{
    public int collectedRobotParts;
    private const int TOTAL_ROBOT_PARTS = 3;

    public int enemiesDefeated;
    public int bossesDefeated;

    #region UI
    public GameObject endGameScreen;
    private Image endCard;
    private TextMeshProUGUI endGameText;
    public Sprite goodEndingSprite, badendingSprite, greyEndingSprite;
    #endregion

    private void Start()
    {
        endCard = endGameScreen.GetComponentInChildren<Image>();
        endGameScreen.SetActive(false);
    }

    public void IncreasePartsCollected()
    {
        collectedRobotParts++;
    }

    public void IncreaseEnemyDefeatedCount()
    {
        enemiesDefeated++;
    }

    public void IncreaseBossesDefeated()
    {
        bossesDefeated++;
    }

    public void CheckForEnding()
    {
        if(enemiesDefeated <= 0)
        {
            if(bossesDefeated <= 0)
            {
                // Good Ending
                endCard.sprite = goodEndingSprite;
            }
        }
        else if(enemiesDefeated > 1 && enemiesDefeated < 10 || bossesDefeated > 1 && bossesDefeated < 3)
        {
            // Grey Ending
            endCard.sprite = greyEndingSprite;
        }
        else
        {
            // Bad Ending
            endCard.sprite = badendingSprite;
        }

        endGameScreen.SetActive(true);
    }
}
