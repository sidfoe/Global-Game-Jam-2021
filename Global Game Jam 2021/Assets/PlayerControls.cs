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
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // LeftEye
        m_LeftEye = asset.FindActionMap("LeftEye", throwIfNotFound: true);
        m_LeftEye_Camera = m_LeftEye.FindAction("Camera", throwIfNotFound: true);
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
    public struct LeftEyeActions
    {
        private @PlayerControls m_Wrapper;
        public LeftEyeActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Camera => m_Wrapper.m_LeftEye_Camera;
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
            }
            m_Wrapper.m_LeftEyeActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Camera.started += instance.OnCamera;
                @Camera.performed += instance.OnCamera;
                @Camera.canceled += instance.OnCamera;
            }
        }
    }
    public LeftEyeActions @LeftEye => new LeftEyeActions(this);
    public interface ILeftEyeActions
    {
        void OnCamera(InputAction.CallbackContext context);
    }
}
