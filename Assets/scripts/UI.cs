using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TMP_Text ScoreText;
    public CanvasGroup StartMenuCanvasGroup;
    public CanvasGroup GuiCanvasGroup;
    // show score
    public void ShowScore(int score)
    {
        ScoreText.text = score.ToString();
    }

    public void ShowStartScreen()
    {
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
    }

    public void HideStartScreen()
    {
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
    }
    
    public void ShowGui()
    {
        CanvasGroupDisplayer.Show(GuiCanvasGroup);
    }

    public void HideGui()
    {
        CanvasGroupDisplayer.Hide(GuiCanvasGroup);
    }
}
