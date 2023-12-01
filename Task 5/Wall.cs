using UnityEngine;

/// <summary>
/// Измените этот скрипт
/// </summary>
public class Wall : MonoBehaviour
{
    [SerializeField]
    private Detector _detector;
    [SerializeField] 
    private Vector3 _targetPosition = new(0, 0, 0f);

    private void Awake()
    {
        // Получаем ссылку на компонент Detector
        if (_detector == null)
        {
            _detector = FindObjectOfType<Detector>();
        }
        
    }
    private void OnEnable()
    {
        // Подписываемся на событие CoinDetected
        if (_detector != null)
        {
            _detector.CoinDetected += ChangePosition;
        }
    }

    private void OnDisable()
    {
        // Отписываемся от события CoinDetected при выключении объекта
        if (_detector != null)
        {
            _detector.CoinDetected -= ChangePosition;
        }
    }

    private void ChangePosition()
    {
        transform.position = _targetPosition;
    }
}