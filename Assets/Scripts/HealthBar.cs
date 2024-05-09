//using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private float _maxHealth = 100;
    private float _currentHealth;
    [SerializeField] private Image _healthBarFill;
    [SerializeField] private TextMeshProUGUI _healthText;
    //[SerializeField] private float _fillSpeed;
    [SerializeField] private Gradient _colorGradient;

    void Start()
    {
        _currentHealth = _maxHealth;
        _healthText.text = "health: " + _currentHealth;
    }

    public void UpdateHealth(float amount) {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0f, _maxHealth);
        _healthText.text = "health: " + _currentHealth;
        UpdateHealthBar();
    }

    private void UpdateHealthBar() {
        float targetFillAmount = _currentHealth / _maxHealth;
        _healthBarFill.fillAmount = targetFillAmount;
        //_healthBarFill.DOFillAmount(targetFillAmount, _fillSpeed);
        _healthBarFill.color= _colorGradient.Evaluate(targetFillAmount);
    }
}
