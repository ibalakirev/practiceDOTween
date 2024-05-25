using DG.Tweening;
using UnityEngine;

public class RotaterCube : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] Vector3 _positionRotation;
    [SerializeField] int _repeats;
    [SerializeField] LoopType _loopType;

    private void Start()
    {
        transform.DORotate(_positionRotation, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(_repeats, _loopType);
    }
}
