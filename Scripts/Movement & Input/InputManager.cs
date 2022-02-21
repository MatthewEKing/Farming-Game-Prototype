using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private PlayerControls playerControls;

    private static InputManager _instance;

    public static InputManager Instance {
        get {
            return _instance;
        }
    }

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        } else {
            _instance = this;
        }
        playerControls = new PlayerControls();
        Cursor.visible = false;
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    //Player Controls

    public Vector2 GetPlayerMovement()
    {
        return playerControls.Player.Movement.ReadValue<Vector2>();
    }

    public Vector2 GetMouseDelta()
    {
        return playerControls.Player.Look.ReadValue<Vector2>();
    }

    public bool Fire()
    {
        return playerControls.Player.Fire.triggered;
    }

    public bool PlayerJumpedThisFrame()
    {
        return playerControls.Player.Jump.triggered;
    }

    public bool PlayerPressedInteract()
    {
        return playerControls.Player.Interact.triggered;
    }

    public bool SwitchToTrowel()
    {
        return playerControls.Player.SwitchToTrowel.triggered;
    }

    public bool SwitchToSeeds()
    {
        return playerControls.Player.SwitchToSeeds.triggered;
    }

    public bool SwitchToWateringCan()
    {
        return playerControls.Player.SwitchToWateringCan.triggered;
    }

    public bool SwitchToCannon()
    {
        return playerControls.Player.SwitchToCannon.triggered;
    }

    public bool SwitchSeedsToTheLeft()
    {
        return playerControls.Player.SwitchSeedsToTheLeft.triggered;
    }

    public bool SwitchSeedsToTheRight()
    {
        return playerControls.Player.SwitchSeedsToTheRight.triggered;
    }


    //Player Commanding Controls

    public bool EnableCommandControls()
    {
        return playerControls.Player.EnableCommandControls.triggered;
    }

    public bool Command()
    {
        return playerControls.Player.Command.triggered;
    }
}
