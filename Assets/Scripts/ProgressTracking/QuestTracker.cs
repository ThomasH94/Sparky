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
    #region Singleton
    public static QuestTracker Instance;

    private void Awake() { Instance = this; }
    #endregion

    //[SerializeField]
    //private int genocideThreshold = 40;

    public int enemiesDefeated;
    public int bossesDefeated;

    [SerializeField]
    private GameObject _endGameScreen;

    [SerializeField]
    private GameObject _goodEndingScreen, _badEndingScreen, _greyEndingScreen;

    private int _possibleEndings = 3;

    public bool ranAway { get; set; }
    public bool badBoi { get; set; }

    public bool batteryMissionComplete { get; set; }
    public bool legMissionComplete { get; set; }
    public bool scrapMissionComplete{ get; set; }

    public bool _anyMissionComplete
    {
        get { return batteryMissionComplete || legMissionComplete || scrapMissionComplete; }
    }

    public bool _allMissionsComplete
    {
        get { return batteryMissionComplete && legMissionComplete && scrapMissionComplete; }
    }

    private int currentEnding;

    private void Start()
    {
        _endGameScreen.SetActive(false);
    }

    public void IncreaseEnemyDefeatedCount()
    {
        enemiesDefeated++;
    }

    public void CheckForEnding()
    {
        if (_allMissionsComplete)
        {
            // Good Ending
            currentEnding = 0;
        }
        else 
        {
            if (ranAway)
            {
                // grey Ending
                currentEnding = 2;
            }
            else if(badBoi)
            {
                // bad Ending
                currentEnding = 1;
            }
        }

        ShowEnding(currentEnding);
    }

    private void ShowEnding(int ending)
    {
        _goodEndingScreen.SetActive(ending == 0);
        _badEndingScreen.SetActive(ending == 1);
        _greyEndingScreen.SetActive(ending == 2);

        _endGameScreen.SetActive(true);
    }
}
