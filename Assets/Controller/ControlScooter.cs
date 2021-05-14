// GENERATED AUTOMATICALLY FROM 'Assets/Controller/ControlScooter.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @ControlScooter : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @ControlScooter()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ControlScooter"",
    ""maps"": [
        {
            ""name"": ""ControlScooter"",
            ""id"": ""fd689052-f040-41dc-9bbd-5aeaac34f95d"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""d669647c-aaad-414a-8870-946a0a60f62d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""58f0f318-d90f-4ba6-a0f6-d6456c080760"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ControlScooter
        m_ControlScooter = asset.FindActionMap("ControlScooter", throwIfNotFound: true);
        m_ControlScooter_Newaction = m_ControlScooter.FindAction("New action", throwIfNotFound: true);
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

    // ControlScooter
    private readonly InputActionMap m_ControlScooter;
    private IControlScooterActions m_ControlScooterActionsCallbackInterface;
    private readonly InputAction m_ControlScooter_Newaction;
    public struct ControlScooterActions
    {
        private @ControlScooter m_Wrapper;
        public ControlScooterActions(@ControlScooter wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_ControlScooter_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_ControlScooter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControlScooterActions set) { return set.Get(); }
        public void SetCallbacks(IControlScooterActions instance)
        {
            if (m_Wrapper.m_ControlScooterActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_ControlScooterActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_ControlScooterActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_ControlScooterActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_ControlScooterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public ControlScooterActions @ControlScooter => new ControlScooterActions(this);
    public interface IControlScooterActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
