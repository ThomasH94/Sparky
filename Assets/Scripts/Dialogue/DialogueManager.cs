using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    #region singleton;
    public static DialogueManager Instance;

    void Awake() { Instance = this; }
    #endregion

    [SerializeField]
    private UIPrompt _dialogueBubble;

    [SerializeField]
    private UIPrompt _interactPrompt;

    private bool _showingPrompt;
    private float _showDialogueTimer = -1;

    void Update()
    {
        if (_showingPrompt && _showDialogueTimer > -1)
        {
            _showDialogueTimer -= Time.deltaTime;

            if (_showDialogueTimer < 0)
            {
                HideDialogue();
            }
        }
    }

    //TODO: pass in a list of strings instead, to queue multiple texts
    //maybe split them by character limit as well, but autosize will do fine

    public void ShowDialogue(string dialogue_, float time_ = -1)
    {
        _dialogueBubble.show(dialogue_);

        _showingPrompt = true;

        if (time_ > -1)
        {
            _showDialogueTimer = time_;
        }
    }

    public void HideDialogue()
    {
        _dialogueBubble.hide();

        resetDialogueTimer();
    }

    private void resetDialogueTimer()
    {
        _showingPrompt = false;

        _showDialogueTimer = -1;
    }

    public void showInteractPrompt()
    {
        _interactPrompt.show();
    }

    public void hideInteractPrompt()
    {
        _interactPrompt.hide();
    }
}
