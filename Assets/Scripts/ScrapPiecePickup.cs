public class ScrapPiecePickup : PickupObject
{
    public override void onPickup(PlayerController player)
    {
        player.PlayerInventory.addItem(RobotPartType.Scrap);

        int amount = player.PlayerInventory.Inventory[RobotPartType.Scrap];

        DialogueManager.Instance.ShowDialogue($"<color=#0ff>Scrap Pieces</color> collected: {amount}", 1);

        Destroy(gameObject);
    }
}