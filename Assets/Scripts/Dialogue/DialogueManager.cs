using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    #region singleton;
    public static DialogueManager Instance;

    void Awake() {
        Instance = this;
    }
    #endregion

    [SerializeField]
    private DialogueBubble _dialogueBubble;

    private bool _showingText;
    private float _showDialogueTimer;

    void Update() {

        if (_showingText && _showDialogueTimer>-1) {

            _showDialogueTimer -= Time.deltaTime;

            if (_showDialogueTimer < 0) {

                HideDialogue();
            }
        }
    }

    public void ShowDialogue(string dialogue_, float time_ = -1) {

        if (_showingText)
            return;

        _dialogueBubble.showTextBox(dialogue_);

        _showingText = true;

        if (time_ > -1) {
            _showDialogueTimer = time_;
        }
    }

    public void HideDialogue() {

        _dialogueBubble.hideTextBox();

        resetDialogueTimer();
    }

    private void resetDialogueTimer() {

        _showingText = false;

        _showDialogueTimer = -1;
    }

}
