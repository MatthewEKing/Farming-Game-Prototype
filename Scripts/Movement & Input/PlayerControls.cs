// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Movement & Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""66ca0f28-78c3-4f92-bdad-37c2143edc9b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""24e7d4a3-a5f3-46f6-b86e-bce5741fb84a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""88554fd6-d72c-41e4-aae0-dcb3503757f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f8eed4cb-c0de-47ef-b753-6174054b13c2"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""2bed873f-1dae-4793-850a-ddfec31ce2ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchToTrowel"",
                    ""type"": ""Button"",
                    ""id"": ""c43b5975-903b-40ca-a17f-ebaa7fb41a76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchToSeeds"",
                    ""type"": ""Button"",
                    ""id"": ""9970265e-ab03-43c6-a74a-a41d45eeab68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchToWateringCan"",
                    ""type"": ""Button"",
                    ""id"": ""1c46f8dd-a091-472d-beac-927a0a1f3175"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchToCannon"",
                    ""type"": ""Button"",
                    ""id"": ""b101b26d-1b56-48a8-9f12-bb70011c4bce"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchSeedsToTheLeft"",
                    ""type"": ""Button"",
                    ""id"": ""41e008bc-ff62-41a2-b7e2-504c899da79e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchSeedsToTheRight"",
                    ""type"": ""Button"",
                    ""id"": ""f1126dab-ac23-491b-80e2-1a4ac65091de"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Value"",
                    ""id"": ""8a017c33-68b9-42bb-a9aa-98b9d0e0831a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""EnableCommandControls"",
                    ""type"": ""Button"",
                    ""id"": ""1e14248c-2465-4030-83a2-9bcbad0ee797"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Command"",
                    ""type"": ""Button"",
                    ""id"": ""c8be0eaf-d21a-4da9-a3a5-81df717608a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""f54f3f69-7b91-4814-9bc9-6fb1666c1da6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9dd33b83-04dd-4bd5-9676-1f6abc90e3d7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7afb244a-7c76-49c4-b18b-353cd39d9431"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d2fb79af-524b-450b-ae37-e633f7ed69bd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""36855979-9f41-4d3d-977e-7c17804f2bb4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ae8dc6ec-9305-44b1-943f-8c2697fedc28"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f38f022-7e36-4b67-879d-fb5e63e9731d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3264993-e9ac-4bdc-accf-332c47077525"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f0a7e35-e1c9-4761-a871-77329ab99ce0"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchToTrowel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e4e48b20-d7a1-40e9-a692-2d0ca771d3e4"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchToSeeds"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16afdb26-06cc-4013-9388-663f6c52f5de"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchToWateringCan"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6f7fe311-a301-40c6-802f-f1fcf788d1db"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchSeedsToTheLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c459d674-02ab-4701-bee6-b1310a771af1"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchSeedsToTheRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""051bb8fc-2fa1-4b0c-86cb-9c12f614034d"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchToCannon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b288ee83-b37c-4ca1-93ec-5357b85257dc"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e3cd7d16-c2a8-4f74-b0ba-2c94a8f3e5f4"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""EnableCommandControls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f53d4a0-b40f-4937-a319-ea1f017d5f17"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Command"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_SwitchToTrowel = m_Player.FindAction("SwitchToTrowel", throwIfNotFound: true);
        m_Player_SwitchToSeeds = m_Player.FindAction("SwitchToSeeds", throwIfNotFound: true);
        m_Player_SwitchToWateringCan = m_Player.FindAction("SwitchToWateringCan", throwIfNotFound: true);
        m_Player_SwitchToCannon = m_Player.FindAction("SwitchToCannon", throwIfNotFound: true);
        m_Player_SwitchSeedsToTheLeft = m_Player.FindAction("SwitchSeedsToTheLeft", throwIfNotFound: true);
        m_Player_SwitchSeedsToTheRight = m_Player.FindAction("SwitchSeedsToTheRight", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_EnableCommandControls = m_Player.FindAction("EnableCommandControls", throwIfNotFound: true);
        m_Player_Command = m_Player.FindAction("Command", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_SwitchToTrowel;
    private readonly InputAction m_Player_SwitchToSeeds;
    private readonly InputAction m_Player_SwitchToWateringCan;
    private readonly InputAction m_Player_SwitchToCannon;
    private readonly InputAction m_Player_SwitchSeedsToTheLeft;
    private readonly InputAction m_Player_SwitchSeedsToTheRight;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_EnableCommandControls;
    private readonly InputAction m_Player_Command;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @SwitchToTrowel => m_Wrapper.m_Player_SwitchToTrowel;
        public InputAction @SwitchToSeeds => m_Wrapper.m_Player_SwitchToSeeds;
        public InputAction @SwitchToWateringCan => m_Wrapper.m_Player_SwitchToWateringCan;
        public InputAction @SwitchToCannon => m_Wrapper.m_Player_SwitchToCannon;
        public InputAction @SwitchSeedsToTheLeft => m_Wrapper.m_Player_SwitchSeedsToTheLeft;
        public InputAction @SwitchSeedsToTheRight => m_Wrapper.m_Player_SwitchSeedsToTheRight;
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @EnableCommandControls => m_Wrapper.m_Player_EnableCommandControls;
        public InputAction @Command => m_Wrapper.m_Player_Command;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Look.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnLook;
                @Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                @SwitchToTrowel.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToTrowel;
                @SwitchToTrowel.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToTrowel;
                @SwitchToTrowel.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToTrowel;
                @SwitchToSeeds.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToSeeds;
                @SwitchToSeeds.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToSeeds;
                @SwitchToSeeds.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToSeeds;
                @SwitchToWateringCan.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToWateringCan;
                @SwitchToWateringCan.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToWateringCan;
                @SwitchToWateringCan.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToWateringCan;
                @SwitchToCannon.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToCannon;
                @SwitchToCannon.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToCannon;
                @SwitchToCannon.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchToCannon;
                @SwitchSeedsToTheLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchSeedsToTheLeft;
                @SwitchSeedsToTheLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchSeedsToTheLeft;
                @SwitchSeedsToTheLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchSeedsToTheLeft;
                @SwitchSeedsToTheRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchSeedsToTheRight;
                @SwitchSeedsToTheRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchSeedsToTheRight;
                @SwitchSeedsToTheRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSwitchSeedsToTheRight;
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @EnableCommandControls.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnableCommandControls;
                @EnableCommandControls.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnableCommandControls;
                @EnableCommandControls.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnEnableCommandControls;
                @Command.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommand;
                @Command.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommand;
                @Command.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnCommand;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @SwitchToTrowel.started += instance.OnSwitchToTrowel;
                @SwitchToTrowel.performed += instance.OnSwitchToTrowel;
                @SwitchToTrowel.canceled += instance.OnSwitchToTrowel;
                @SwitchToSeeds.started += instance.OnSwitchToSeeds;
                @SwitchToSeeds.performed += instance.OnSwitchToSeeds;
                @SwitchToSeeds.canceled += instance.OnSwitchToSeeds;
                @SwitchToWateringCan.started += instance.OnSwitchToWateringCan;
                @SwitchToWateringCan.performed += instance.OnSwitchToWateringCan;
                @SwitchToWateringCan.canceled += instance.OnSwitchToWateringCan;
                @SwitchToCannon.started += instance.OnSwitchToCannon;
                @SwitchToCannon.performed += instance.OnSwitchToCannon;
                @SwitchToCannon.canceled += instance.OnSwitchToCannon;
                @SwitchSeedsToTheLeft.started += instance.OnSwitchSeedsToTheLeft;
                @SwitchSeedsToTheLeft.performed += instance.OnSwitchSeedsToTheLeft;
                @SwitchSeedsToTheLeft.canceled += instance.OnSwitchSeedsToTheLeft;
                @SwitchSeedsToTheRight.started += instance.OnSwitchSeedsToTheRight;
                @SwitchSeedsToTheRight.performed += instance.OnSwitchSeedsToTheRight;
                @SwitchSeedsToTheRight.canceled += instance.OnSwitchSeedsToTheRight;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @EnableCommandControls.started += instance.OnEnableCommandControls;
                @EnableCommandControls.performed += instance.OnEnableCommandControls;
                @EnableCommandControls.canceled += instance.OnEnableCommandControls;
                @Command.started += instance.OnCommand;
                @Command.performed += instance.OnCommand;
                @Command.canceled += instance.OnCommand;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSwitchToTrowel(InputAction.CallbackContext context);
        void OnSwitchToSeeds(InputAction.CallbackContext context);
        void OnSwitchToWateringCan(InputAction.CallbackContext context);
        void OnSwitchToCannon(InputAction.CallbackContext context);
        void OnSwitchSeedsToTheLeft(InputAction.CallbackContext context);
        void OnSwitchSeedsToTheRight(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnEnableCommandControls(InputAction.CallbackContext context);
        void OnCommand(InputAction.CallbackContext context);
    }
}
