using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{
    [SerializeField]
    protected Image _fillImage;
    [SerializeField]
    protected Slider _fillSlider;

    [SerializeField]
    private bool _hideWhenEmpty;

    protected float _fillValue = 1;

    protected virtual void Reset()
    {
        _fillSlider = GetComponent<Slider>();
    }

    protected virtual void Start()
    {
        BindSlider();
    }

    protected virtual void SetFill(float amount)
    {
        _fillValue = amount;

        BindSlider();
    }

    protected virtual void UpdateFill(float amount)
    {
        _fillValue += amount;

        BindSlider();
    }

    // Updates our slider values based on the amount of health remaining and disables the
    // fill image if we are less than a minimum threshold - defined in the inspector
    public virtual void BindSlider()
    {
        _fillSlider.value = _fillValue;

        if(_fillSlider.value <= _fillSlider.minValue)
        {
            Removebar();
        }
    }

    private void Removebar()
    {
        if (_hideWhenEmpty)
        {
            _fillSlider.gameObject.SetActive(false);
        }
    }
}
