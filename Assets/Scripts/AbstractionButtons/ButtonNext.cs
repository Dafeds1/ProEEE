using UnityEngine;
using UnityEngine.UI;

public class ButtonNext : AbstractCanvasButton
{
    public override void OnCLick()
    {
        _isNext = true;
        ChangeCanvas(CurrentCanvas, _isNext, NextCanvas, BackCanvas);
    }

}
