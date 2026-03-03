using UnityEngine;

public class Game : MonoBehaviour
{
    public UI Ui;
    private static bool isGameStarted = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        Ui.ShowStartScreen();
        Ui.HideGui();
    }
    
    public void OnStartButtonClick()
    {
        Ui.HideStartScreen();
        Ui.ShowGui();
        isGameStarted = true;
    }

    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
    
}
