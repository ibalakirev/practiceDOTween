using DG.Tweening;
using UnityEngine;

public class SequencesAnimationsCube : MonoBehaviour
{
    [SerializeField] private Transform _targetPosition;
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _scale;
    [SerializeField] int _repeats;
    [SerializeField] LoopType _loopTypeRotate;
    [SerializeField] LoopType _loopTypeMove;
    [SerializeField] LoopType _loopTypeScale;
    [SerializeField] Vector3 _rotation;

    private void Start()
    {
        transform.DORotate(_rotation, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(_repeats, _loopTypeRotate); 

        transform.DOMove(_targetPosition.position, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(_repeats, _loopTypeMove); 

        transform.DOScale(_scale, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(_repeats, _loopTypeScale);
    }
}
