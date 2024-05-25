using DG.Tweening;
using UnityEngine;

public class ColorizerCylinder : MonoBehaviour
{
    [SerializeField] private MeshRenderer _meshRenderer;
    [SerializeField] private Color _color;
    [SerializeField] float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] LoopType _loopType;

    private void Start()
    {
        _meshRenderer.material.DOColor(_color, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(_repeats, _loopType);
    }
}
