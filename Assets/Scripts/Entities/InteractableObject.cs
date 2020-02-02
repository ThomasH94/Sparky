using UnityEngine;

public class InteractableObject : EntityController {

    private PlayerController _playerController = null;

    [SerializeField]
    private bool showInteractionPrompt;

    [SerializeField]
    private Transform interactPromptPosition;

    private void OnTriggerEnter2D(Collider2D other) {

        _playerController = other.GetComponent<PlayerController>();

        if (_playerController) {
            _playerController.CurrentInteractAction = InteractAction;
        }

        if (showInteractionPrompt)
        {
            DialogueManager.Instance.showInteractPrompt(interactPromptPosition.position);
        }
    }

    private void OnTriggerExit2D(Collider2D other) {

        if (_playerController) {
            _playerController.CurrentInteractAction = null;
            _playerController = null;
        }

        DialogueManager.Instance.hideInteractPrompt();
    }

    public virtual void InteractAction() {

    }

}
