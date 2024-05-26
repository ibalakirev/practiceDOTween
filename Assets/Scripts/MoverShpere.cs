using DG.Tweening;
using UnityEngine;

public class MoverShpere : MonoBehaviour
{
    [SerializeField] private Transform _targetPosition;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_targetPosition.position, _duration)
            .SetEase(Ease.Linear)
            .SetDelay(_delay)
            .SetLoops(_repeats, _loopType);
    }
}
