public class ScrapPiecePickup : PickupObject
{
    public override void onPickup(PlayerController player)
    {
        player.PlayerInventory.addItem("scrap");
    }
}