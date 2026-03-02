using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLauncher : MonoBehaviour
{
   public Launcher Launcher;
   
    void Update()
    {
        //if (!Game.IsGameStarted())
        //    return;
        if (Mouse.current == null)
            return;
        
        // if the mouse is clicked 
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Launch();
        }
        // launch ball
    }

    private void Launch()
    {
        // figure out direction to aim
        Vector2 aimDirection = GetAimDirection();
        
        // launch in that direction
        Launcher.Launch(aimDirection);
    }

    private Vector2 GetAimDirection()
    {
        Vector3 mouseWorld = GetMouseWorldPosition();
        return (mouseWorld - transform.position).normalized;
    }
    
    private Vector3 GetMouseWorldPosition()
    {
        Vector2 mouseScreen = Mouse.current.position.ReadValue();
        Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(mouseScreen);
        mouseWorld.z = 0;
        return mouseWorld;
        
    }
}
