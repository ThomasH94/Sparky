using UnityEngine;
using System.Collections.Generic;
using System;

public class NPCController : InteractableObject {

    [SerializeField]
    private Animator _buddyAnimator;

    [SerializeField]
    private GameObject _batteryCompletePart, _legPartComplete, _scrapPartComplete;

    //TODO: get a requirement class to loop through instead of these properties
    [SerializeField]
    private int _batteryRequirement = 1;
    [SerializeField]
    private int _legRequirement = 1;
    [SerializeField]
    private int _scrapRequirement = 30;
    [SerializeField]
    private int _scrapUpgradeInterval = 10;
    
    [SerializeField]
    private int _batteryHealthUpgrade = 50;
    [SerializeField]
    private float _legSpeedUpgrade = 5;
    [SerializeField]
    private int _scrapDamageUpgrade = 3000;

    private QuestTracker _tracker;
    private PlayerController _player;
    private int _scrapUpgradesGiven;
    private int _ouches;

    private bool _playerHasBattery, _playerHasLeg, _playerHasScrap, _playerHasAllScrap;

    //TODO: get a requirement class to loop through instead of these properties
    private bool anyPartFound
    {
        get { return _playerHasBattery || _playerHasLeg || _playerHasScrap; }
    }

    private bool batteryPending
    {
        get { return !_tracker.batteryMissionComplete && _playerHasBattery; }
    }

    private bool legPending
    {
        get { return !_tracker.legMissionComplete && _playerHasLeg; }
    }

    private bool scrapPending
    {
        get { return !_tracker.scrapMissionComplete && _playerHasScrap; }
    }

    private bool anyPartPending
    {
        get { return batteryPending || legPending || scrapPending; }
    }

    private int currentScrapIntervalRequirement
    {
        get { return _scrapUpgradeInterval * (1 + _scrapUpgradesGiven); }
    }

    private int totalScrapUpgrades
    {
        get { return Mathf.CeilToInt(_scrapRequirement / _scrapUpgradeInterval); }
    }

    protected override void Start()
    {
        _tracker = QuestTracker.Instance;
        base.Start();
    }

    public override void InteractAction(PlayerController player_)
    {
        base.InteractAction(player_);

        _player = player_;

        CheckPlayerInventory();

        Respond();
        CheckUpgrades();
        UpdateParts();
    }

    private void UpdateParts()
    {
        if (_batteryCompletePart)
        {
            _batteryCompletePart.SetActive(_tracker.batteryMissionComplete);
        }
        if (_legPartComplete)
        {
            _legPartComplete.SetActive(_tracker.legMissionComplete);
        }
        if (_scrapPartComplete)
        {
            _scrapPartComplete.SetActive(_tracker.scrapMissionComplete);
        }
    }

    private void Respond()
    {
        if (_tracker._allMissionsComplete)
        {
            _tracker.CheckForEnding();
            return;
        }

        string response = "";

        if (!_tracker._allMissionsComplete && anyPartPending)
        {
            response = "AH! You've found some parts!";

            if (!_tracker.batteryMissionComplete && _playerHasBattery)
            {
                response += "\nYour <color=#0ff>health</color> has been upgraded!";
            }

            if (!_tracker.legMissionComplete && _playerHasLeg)
            {
                response += "\nYour <color=#0ff>speed</color> has been upgraded! ";
            }

            if (!_tracker.legMissionComplete && _playerHasScrap)
            {
                response += "\nYour <color=#0ff>attack</color> has been upgraded! ";
            }

            _buddyAnimator.Play("happy");
        }
        else if (!_tracker._allMissionsComplete)
        {
            response += "Hello! Can you help me? I'm missing some parts:\n";

            if (!_tracker.batteryMissionComplete)
            {
                response += "my <color=#0ff>[battery]</color>, ";
            }

            if (!_tracker.legMissionComplete)
            {
                response += "my <color=#0ff>[leg]</color>, ";
            }

            if (!_tracker.scrapMissionComplete)
            {
                response += $"my <color=#0ff>[{_scrapRequirement} scrap pieces]</color>, ";
            }

            response += ":c.";

            _buddyAnimator.Play("sad");
        }

        DialogueManager.Instance.ShowDialogue(response, 6);
    }

    private void CheckPlayerInventory()
    {
        Dictionary<RobotPartType, int> playerInv = _player.PlayerInventory;

        foreach (KeyValuePair<RobotPartType, int> kvp in playerInv)
        {
            switch (kvp.Key)
            {
                case RobotPartType.Battery:

                    if(kvp.Value >= _batteryRequirement)
                    {
                        _playerHasBattery = true;
                    }
                    break;

                case RobotPartType.Leg:

                    if (kvp.Value >= _legRequirement)
                    {
                        _playerHasLeg = true;
                    }
                    break;

                case RobotPartType.Scrap:
                    if (kvp.Value >= currentScrapIntervalRequirement)
                    {
                        _playerHasScrap = true;

                        if (kvp.Value >= _scrapRequirement)
                        {
                            _playerHasAllScrap = true;
                        }
                    } else
                    {
                        _playerHasScrap = false;
                    }
                    break;
            }
        }
    }

    private void CheckUpgrades()
    {
        if(!_tracker.batteryMissionComplete && _playerHasBattery)
        {
            upgradePlayerHealth();
            _tracker.batteryMissionComplete = true;
        }

        if (!_tracker.legMissionComplete && _playerHasLeg)
        {
            upgradePlayerSpeed();
            _tracker.legMissionComplete = true;
        }

        if (!_tracker.scrapMissionComplete && _playerHasScrap)
        {
            upgradePlayerDamage();
            _scrapUpgradesGiven++;

            if (_scrapUpgradesGiven >= totalScrapUpgrades)
            {
                _tracker.scrapMissionComplete = true;
            }
        }

        _player.HealthUpdatedEvent?.Invoke(0);
    }

    private void upgradePlayerHealth()
    {
        _player.maxHealth += _batteryHealthUpgrade;
        _player.health = _player.maxHealth;
    }

    private void upgradePlayerSpeed()
    {
        _player.baseMoveSpeed += _legSpeedUpgrade;
        _player.moveSpeed = _player.baseMoveSpeed;
        _player.health = _player.maxHealth;
    }

    private void upgradePlayerDamage()
    {
        _player.damageScale += _scrapDamageUpgrade;
        _player.health = _player.maxHealth;
    }

    public override void DoDie()
    {
        base.DoDie();

        _tracker.badBoi = true;
        _tracker.CheckForEnding();
    }

    public override int DoDamage(int amount)
    {
        if (health <= maxHealth - 30 && health > maxHealth - 50)
        {
            DialogueManager.Instance.ShowDialogue("ouch!");
        }

        if(health <= 30)
        {
            _ouches++;

            string ouch = "OUCH!";
            for (int i = 0; i < _ouches; i++)
            {
                ouch += " OUCH!";
            }
            DialogueManager.Instance.ShowDialogue(ouch);
        }

        return base.DoDamage(amount);
    }
}
