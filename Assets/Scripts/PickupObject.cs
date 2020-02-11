using UnityEngine;

public class PickupObject : MonoBehaviour
{
    private PlayerController _playerController = null;

    private void OnTriggerEnter(Collider other)
    {
        _playerController = other.GetComponent<PlayerController>();

        if (_playerController)
        {
            onPickup(_playerController);
            _playerController = null;
        }
    }

    public virtual void onPickup(PlayerController player) { }
}
