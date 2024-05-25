using DG.Tweening;
using UnityEngine;

public class MoverShpere : MonoBehaviour
{
    [SerializeField] Transform _targetPosition;
    [SerializeField] float _duration;
    [SerializeField] float _delay;
    [SerializeField] int _repeats;
    [SerializeField] LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_targetPosition.position, _duration)
            .SetEase(Ease.Linear)
            .SetDelay(_delay)
            .SetLoops(_repeats, _loopType);
    }
}
