using TMPro;
using UnityEngine;

public class DialogueBubble : MonoBehaviour {

    [SerializeField]
    private GameObject _textBox;

    [SerializeField]
    private TMP_Text _textField;

    void Awake() {
        hideTextBox();    
    }

    //TODO: pass in a list of strings instead, to queue multiple texts
    //maybe split them by character limit as well, but autosize will do fine
    public void showTextBox(string dialogue_) {

        _textField.text = dialogue_;

        _textBox.gameObject.SetActive(true);
    }

    public void hideTextBox() {
        _textBox.gameObject.SetActive(false);
    }
}
