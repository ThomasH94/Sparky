using UnityEngine;

public class TestNPC : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision) {

        DialogueManager.Instance.ShowDialogue("OUCH GET OUTTA HERE");

    }

    private void OnTriggerExit2D(Collider2D collision) {

        DialogueManager.Instance.HideDialogue();
    }
}
