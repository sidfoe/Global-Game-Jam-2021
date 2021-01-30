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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LeftEye
        m_LeftEye = asset.FindActionMap("LeftEye", throwIfNotFound: true);
        m_LeftEye_Camera = m_LeftEye.FindAction("Camera", throwIfNotFound: true);
        m_LeftEye_Movement = m_LeftEye.FindAction("Movement", throwIfNotFound: true);
        m_LeftEye_EyeSwitch = m_LeftEye.FindAction("Eye Switch", throwIfNotFound: true);
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
    private readonly InputAction m_LeftEye_Camera;
    private readonly InputAction m_LeftEye_Movement;
    private readonly InputAction m_LeftEye_EyeSwitch;
    public struct LeftEyeActions
    {
        private @PlayerControls m_Wrapper;
        public LeftEyeActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Camera => m_Wrapper.m_LeftEye_Camera;
        public InputAction @Movement => m_Wrapper.m_LeftEye_Movement;
        public InputAction @EyeSwitch => m_Wrapper.m_LeftEye_EyeSwitch;
        public InputActionMap Get() { return m_Wrapper.m_LeftEye; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(LeftEyeActions set) { return set.Get(); }
        public void SetCallbacks(ILeftEyeActions instance)
        {
            if (m_Wrapper.m_LeftEyeActionsCallbackInterface != null)
            {
                @Camera.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnCamera;
                @Camera.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnCamera;
                @Camera.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnCamera;
                @Movement.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnMovement;
                @EyeSwitch.started -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnEyeSwitch;
                @EyeSwitch.performed -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnEyeSwitch;
                @EyeSwitch.canceled -= m_Wrapper.m_LeftEyeActionsCallbackInterface.OnEyeSwitch;
            }
            m_Wrapper.m_LeftEyeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @EyeSwitch.started += instance.OnEyeSwitch;
                @EyeSwitch.performed += instance.OnEyeSwitch;
                @EyeSwitch.canceled += instance.OnEyeSwitch;
            }
        }
    }
    public LeftEyeActions @LeftEye => new LeftEyeActions(this);
    public interface ILeftEyeActions
    {
        void OnCamera(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnEyeSwitch(InputAction.CallbackContext context);
    }
}
