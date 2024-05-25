using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SequencesAnimationsText : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void Start()
    {
        float duration = 2f;
        float delay = 2f;
        int loopValue = -1;
        string textReplaced = "� ������� ���� �����";
        string textAdded = "� ������� ���� �����";
        string textScrambled = "� �������� ���� �����";

        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(textReplaced, duration));
        sequence.Append(_text.DOText(textAdded, duration).SetRelative().SetDelay(delay));
        sequence.Append(_text.DOText(textScrambled, duration, true, ScrambleMode.All));

        sequence.SetLoops(loopValue);
    }
}
