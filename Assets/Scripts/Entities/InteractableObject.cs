using UnityEngine;

public class InteractableObject : EntityController
{
    private PlayerController _playerController = null;

    [SerializeField]
    private bool showInteractionPrompt;

    [SerializeField]
    private Transform interactPromptPosition;

    private void OnTriggerEnter(Collider other)
    {
        _playerController = other.GetComponent<PlayerController>();

        if (_playerController)
        {
            _playerController.CurrentInteractAction = InteractAction;
        }

        if (showInteractionPrompt)
        {
            Vector3 promptPosition = interactPromptPosition? interactPromptPosition.position: transform.position;

            DialogueManager.Instance.showInteractPrompt(interactPromptPosition.position);
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

    }
}
