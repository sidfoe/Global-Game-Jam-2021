// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

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
            ""name"": ""LeftEye"",
            ""id"": ""14a0905c-dd1c-4353-88ea-da30280bd88b"",
            ""actions"": [
                {
                    ""name"": ""Click To Look"",
                    ""type"": ""Button"",
                    ""id"": ""4a6e7ea1-07df-49b1-aca0-77d504f85f49"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.05)""
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""Value"",
                    ""id"": ""155e6161-459d-4eaf-95c5-2d2c452fc720"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""4be93a06-a2ba-47c2-a40e-242c846a18be"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Eye Switch"",
                    ""type"": ""Button"",
                    ""id"": ""37cf68e4-d430-4ebf-817f-f7507695dae1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateBodyLeft"",
                    ""type"": ""Button"",
                    ""id"": ""9e24eaab-fcff-4667-902e-e1a30925aa5b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.05)""
                },
                {
                    ""name"": ""RotateBodyRight"",
                    ""type"": ""Button"",
                    ""id"": ""8166854a-ab5a-4b3a-a9af-b740daadabdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold(duration=0.05)""
                },
                {
                    ""name"": ""PickUp"",
                    ""type"": ""Button"",
                    ""id"": ""f42f83f3-d8cf-4fbd-a0f6-ec657b12eb8f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""257cc5dc-34a9-49bb-b840-415c317e35af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back To Main"",
                    ""type"": ""Button"",
                    ""id"": ""62dd646b-ff55-4a4a-81ab-ff5887abe607"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Restart"",
                    ""type"": ""Button"",
                    ""id"": ""4e7364dd-6327-4394-b67a-3ece88e70454"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""47eddcc6-3d7e-4512-ac74-1e4240f658bb"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""9a9f108c-7719-484b-967f-c6ef5da56e7f"",
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
                    ""id"": ""4d380e8d-495d-4309-9457-9c98425b1dc7"",
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
                    ""id"": ""bcedc661-3e59-40c5-909b-d8de974ce0b6"",
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
                    ""id"": ""009cc2a2-8ed2-45af-81c5-bc4c82566d65"",
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
                    ""id"": ""c5a8a08c-8d02-4ff3-a1c9-5000efb28620"",
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
                    ""id"": ""fa5b3281-dc2f-4bb3-b503-0380ca7c17d4"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Eye Switch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ac028e4-8c8a-4c31-88b4-71dc4b2e5d2e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Click To Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc4a85ff-6bce-4788-81bf-14159c11c099"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateBodyLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6d2ba4f7-cad4-4457-9203-2f31faa139ee"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateBodyRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""552aad3b-0c2f-420e-ac9a-237536a3eebc"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PickUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b07df5e-2053-435f-9afa-59767e7addde"",
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
                    ""id"": ""197ee2ce-0d3b-4f5c-a2fa-cc58d1d22fef"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back To Main"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5fb0709d-445c-4b19-91be-dbf55a8957f6"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LeftEye
        m_LeftEye = asset.FindActionMap("LeftEye", throwIfNotFound: true);
        m_LeftEye_ClickToLook = m_LeftEye.FindAction("Click To Look", throwIfNotFound: true);
        m_LeftEye_Camera = m_LeftEye.FindAction("Camera", throwIfNotFound: true);
        m_LeftEye_Movement = m_LeftEye.FindAction("Movement", throwIfNotFound: true);
        m_LeftEye_EyeSwitch = m_LeftEye.FindAction("Eye Switch", throwIfNotFound: true);
        m_LeftEye_RotateBodyLeft = m_LeftEye.FindAction("RotateBodyLeft", throwIfNotFound: true);
        m_LeftEye_RotateBodyRight = m_LeftEye.FindAction("RotateBodyRight", throwIfNotFound: true);
        m_LeftEye_PickUp = m_LeftEye.FindAction("PickUp", throwIfNotFound: true);
        m_LeftEye_Jump = m_LeftEye.FindAction("Jump", throwIfNotFound: true);
        m_LeftEye_BackToMain = m_LeftEye.FindAction("Back To Main", throwIfNotFound: true);
        m_LeftEye_Restart = m_LeftEye.FindAction("Restart", throwIfNotFound: true);
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

    // LeftEye
    private readonly InputActionMap m_LeftEye;
    private ILeftEyeActions m_LeftEyeActionsCallbackInterface;
    private readonly InputAction m_LeftEye_ClickToLook;
    private readonly InputAction m_LeftEye_Camera;
    private readonly InputAction m_LeftEye_Movement;
    private readonly InputAction m_LeftEye_EyeSwitch;
    private readonly InputAction m_LeftEye_RotateBodyLeft;
    private readonly InputAction m_LeftEye_RotateBodyRight;
    private readonly InputAction m_LeftEye_PickUp;
    private readonly InputAction m_LeftEye_Jump;
    private readonly InputAction m_LeftEye_BackToMain;
    private readonly InputAction m_LeftEye_Restart;
    public struct LeftEyeActions
    {
        private @PlayerControls m_Wrapper;
        public LeftEyeActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @ClickToLook => m_Wrapper.m_LeftEye_ClickToLook;
        public InputAction @Camera => m_Wrapper.m_LeftEye_Camera;
        public InputAction @Movement => m_Wrapper.m_LeftEye_Movement;
        public InputAction @EyeSwitch => m_Wrapper.m_LeftEye_EyeSwitch;
        public InputAction @RotateBodyLeft => m_Wrapper.m_LeftEye_RotateBodyLeft;
        public InputAction @RotateBodyRight => m_Wrapper.m_LeftEye_RotateBodyRight;
        public InputAction @PickUp => m_Wrapper.m_LeftEye_PickUp;
        public InputAction @Jump => m_Wrapper.m_LeftEye_Jump;
        public InputAction @BackToMain => m_Wrapper.m_LeftEye_BackToMain;
        public InputAction @Restart => m_Wrapper.m_LeftEye_Restart;
        public InputActionMap Get() { return m_Wrapper.m_LeftEye; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftEyeActions set) { return set.Get(); }
        public void SetCallbacks(ILeftEyeActions instance)
        {
            if (m_Wrapper.m_LeftEyeActionsCallbackInterface != null)
            {
                @ClickToLook.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnClickToLook;
                @ClickToLook.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnClickToLook;
                @ClickToLook.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnClickToLook;
                @Camera.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnCamera;
                @Movement.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnMovement;
                @EyeSwitch.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnEyeSwitch;
                @EyeSwitch.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnEyeSwitch;
                @EyeSwitch.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnEyeSwitch;
                @RotateBodyLeft.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnRotateBodyLeft;
                @RotateBodyLeft.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnRotateBodyLeft;
                @RotateBodyLeft.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnRotateBodyLeft;
                @RotateBodyRight.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnRotateBodyRight;
                @RotateBodyRight.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnRotateBodyRight;
                @RotateBodyRight.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnRotateBodyRight;
                @PickUp.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnPickUp;
                @PickUp.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnPickUp;
                @PickUp.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnPickUp;
                @Jump.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnJump;
                @BackToMain.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnBackToMain;
                @BackToMain.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnBackToMain;
                @BackToMain.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnBackToMain;
                @Restart.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnRestart;
                @Restart.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnRestart;
                @Restart.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnRestart;
            }
            m_Wrapper.m_LeftEyeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @ClickToLook.started += instance.OnClickToLook;
                @ClickToLook.performed += instance.OnClickToLook;
                @ClickToLook.canceled += instance.OnClickToLook;
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @EyeSwitch.started += instance.OnEyeSwitch;
                @EyeSwitch.performed += instance.OnEyeSwitch;
                @EyeSwitch.canceled += instance.OnEyeSwitch;
                @RotateBodyLeft.started += instance.OnRotateBodyLeft;
                @RotateBodyLeft.performed += instance.OnRotateBodyLeft;
                @RotateBodyLeft.canceled += instance.OnRotateBodyLeft;
                @RotateBodyRight.started += instance.OnRotateBodyRight;
                @RotateBodyRight.performed += instance.OnRotateBodyRight;
                @RotateBodyRight.canceled += instance.OnRotateBodyRight;
                @PickUp.started += instance.OnPickUp;
                @PickUp.performed += instance.OnPickUp;
                @PickUp.canceled += instance.OnPickUp;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @BackToMain.started += instance.OnBackToMain;
                @BackToMain.performed += instance.OnBackToMain;
                @BackToMain.canceled += instance.OnBackToMain;
                @Restart.started += instance.OnRestart;
                @Restart.performed += instance.OnRestart;
                @Restart.canceled += instance.OnRestart;
            }
        }
    }
    public LeftEyeActions @LeftEye => new LeftEyeActions(this);
    public interface ILeftEyeActions
    {
        void OnClickToLook(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnEyeSwitch(InputAction.CallbackContext context);
        void OnRotateBodyLeft(InputAction.CallbackContext context);
        void OnRotateBodyRight(InputAction.CallbackContext context);
        void OnPickUp(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBackToMain(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
    }
}
