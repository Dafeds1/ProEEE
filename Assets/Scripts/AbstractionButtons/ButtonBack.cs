using UnityEngine;
using UnityEngine.UI;

public class ButtonBack : AbstractCanvasButton
{


    public override void OnCLick()
    {
        _isNext = false;
        ChangeCanvas(CurrentCanvas, _isNext, NextCanvas, BackCanvas);
    }

}
