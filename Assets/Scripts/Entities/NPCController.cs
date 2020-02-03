using UnityEngine;
using System.Collections.Generic;
using System;

public class NPCController : InteractableObject {

    [SerializeField]
    private Animator _buddyAnimator;

    [SerializeField]
    private GameObject _batteryCompletePart, _legPartComplete, _scrapPartComplete;

    [SerializeField]
    private int _batteryRequirement = 1;
    [SerializeField]
    private int _legRequirement = 1;
    [SerializeField]
    private int _scrapRequirement = 20;

    [SerializeField]
    private int _batteryHealthUpgrade = 50;
    [SerializeField]
    private float _legSpeedUpgrade = 5;
    [SerializeField]
    private int _scrapDamageUpgrade = 3000;

    private QuestTracker _tracker;
    private PlayerController _player;

    private bool _playerHasBattery, _playerHasLeg, _playerHasScrap;

    private bool _anyPartFound
    {
        get { return _playerHasBattery || _playerHasLeg || _playerHasScrap; }
    }

    private bool _batteryPending
    {
        get { return !_tracker.batteryMissionComplete && _playerHasBattery; }
    }

    private bool _legPending
    {
        get { return !_tracker.legMissionComplete && _playerHasLeg; }
    }

    private bool _scrapPending
    {
        get { return !_tracker.scrapMissionComplete && _playerHasScrap; }
    }

    private bool _anyPartPending
    {
        get { return _batteryPending || _legPending || _scrapPending; }
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
        }

        string response = "";

        if (!_tracker._allMissionsComplete && _anyPartPending)
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
                response += "my <color=#0ff>[battery]</color> ";
            }

            if (!_tracker.legMissionComplete)
            {
                response += "my <color=#0ff>[leg]</color> ";
            }

            if (!_tracker.legMissionComplete)
            {
                response += $"my <color=#0ff>[{_scrapRequirement} scrap pieces]</color> ";
            }

            response += " :c.";

            _buddyAnimator.Play("sad");
        }

        DialogueManager.Instance.ShowDialogue(response, 4);
    }

    private void CheckPlayerInventory()
    {
        Dictionary<RobotPartType, int> playerInv = _player.PlayerInventory.Inventory;

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
                    if (kvp.Value >= _scrapRequirement)
                    {
                        _playerHasScrap = true;
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

        if (!_tracker.legMissionComplete && _playerHasScrap)
        {
            upgradePlayerDamage();
            _tracker.legMissionComplete = true;
        }
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
        //_player.attack += _scrapDamageUpgrade;
        _player.health = _player.maxHealth;
    }

    public override void DoDie()
    {
        base.DoDie();
        //gameover
    }
}
