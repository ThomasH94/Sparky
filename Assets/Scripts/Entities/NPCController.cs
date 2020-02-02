public class NPCController : InteractableObject {

    public override void InteractAction() {

        DialogueManager.Instance.ShowDialogue("OUCH GET OUTTA HERE", 3);
    }
}
