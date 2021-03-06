﻿using UnityEngine;

public class InteractableObject : EntityController
{
    private PlayerController _playerController = null;

    [SerializeField]
    private bool showInteractionPrompt;

    //[SerializeField]
    //private Transform interactPromptPosition;
    //TODO: have press E prompt be next to folks

    private void OnTriggerEnter(Collider other)
    {
        _playerController = other.GetComponent<PlayerController>();

        if (_playerController)
        {
            _playerController.CurrentInteractAction = InteractAction;

            if (showInteractionPrompt)
            {
                DialogueManager.Instance.showInteractPrompt();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (_playerController)
        {
            _playerController.CurrentInteractAction = null;
            _playerController = null;
        }

        DialogueManager.Instance.hideInteractPrompt();
    }

    public virtual void InteractAction(PlayerController player)
    {
        //DialogueManager.Instance.hideInteractPrompt();
    }
}
