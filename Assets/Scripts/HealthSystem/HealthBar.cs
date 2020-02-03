using TMPro;
using UnityEngine;
public class HealthBar : FillStatusBar
{
    [SerializeField, Space]
    private Damageable _damageableEntityReference;

    [SerializeField]
    private TMP_Text _healthText;

    [SerializeField]
    private Color _healthColor = Color.cyan;
    [SerializeField]
    private Color _lowHealthColor = Color.red;

    [SerializeField, Range(0, 1)]
    private float lowHealthThreshold;

    private bool _subscribedToEvents;

    protected override void Start()
    {
        subscribeToEvents(true);
        base.Start();
    }

    private void OnDestroy()
    {
        subscribeToEvents(false);
    }

    private void subscribeToEvents(bool subscribe_)
    {
        if (_subscribedToEvents == subscribe_)
            return;

        _subscribedToEvents = subscribe_;

        if (subscribe_ && _damageableEntityReference == null)
        {
            Debug.Log("<color=red>damageable reference not assigned</color>", this);
            return;
        }

        if (subscribe_)
        {
            _damageableEntityReference.HealthUpdatedEvent += onHealthUpdated;
        }
        else
        {
            _damageableEntityReference.HealthUpdatedEvent -= onHealthUpdated;
        }
    }

    private void onHealthUpdated(float amount)
    {
        SetFill(amount);

        if (_healthText)
        {
            int max = _damageableEntityReference.maxHealth;
            int hp = _damageableEntityReference.health;
            _healthText.text = $"HEALTH: {max} / {hp}";
        }
    }

    public override void BindSlider()
    {
        if (_fillValue > lowHealthThreshold)
        {
            _fillImage.color = _healthColor;
        }
        else
        {
            _fillImage.color = _lowHealthColor;
        }

        base.BindSlider();
    }
}
