using DG.Tweening;
using UnityEngine;

public class RotaterCube : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _positionRotation;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DORotate(_positionRotation, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(_repeats, _loopType);
    }
}
