using UnityEngine;

public class NPCController : InteractableObject {

    public override void InteractAction(PlayerController player) {

        DialogueManager.Instance.ShowDialogue("OUCH GET OUTTA HERE", 3);
    }
}
