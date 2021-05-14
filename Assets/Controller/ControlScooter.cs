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
            ""name"": ""Scooter"",
            ""id"": ""fd689052-f040-41dc-9bbd-5aeaac34f95d"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d669647c-aaad-414a-8870-946a0a60f62d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Lateral"",
                    ""type"": ""Button"",
                    ""id"": ""4d78d22b-0e51-4234-9cde-f16ce27f2405"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""58f0f318-d90f-4ba6-a0f6-d6456c080760"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""2ffe9777-fd4f-4e39-89bc-4de727371337"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lateral"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b6e57ac0-12a2-4e42-9fb8-0dbbc5b97f37"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lateral"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""fb3e5183-c79c-45c1-981d-7b11b9632bb0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Lateral"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Scooter
        m_Scooter = asset.FindActionMap("Scooter", throwIfNotFound: true);
        m_Scooter_Jump = m_Scooter.FindAction("Jump", throwIfNotFound: true);
        m_Scooter_Lateral = m_Scooter.FindAction("Lateral", throwIfNotFound: true);
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

    // Scooter
    private readonly InputActionMap m_Scooter;
    private IScooterActions m_ScooterActionsCallbackInterface;
    private readonly InputAction m_Scooter_Jump;
    private readonly InputAction m_Scooter_Lateral;
    public struct ScooterActions
    {
        private @ControlScooter m_Wrapper;
        public ScooterActions(@ControlScooter wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Scooter_Jump;
        public InputAction @Lateral => m_Wrapper.m_Scooter_Lateral;
        public InputActionMap Get() { return m_Wrapper.m_Scooter; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ScooterActions set) { return set.Get(); }
        public void SetCallbacks(IScooterActions instance)
        {
            if (m_Wrapper.m_ScooterActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_ScooterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ScooterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ScooterActionsCallbackInterface.OnJump;
                @Lateral.started -= m_Wrapper.m_ScooterActionsCallbackInterface.OnLateral;
                @Lateral.performed -= m_Wrapper.m_ScooterActionsCallbackInterface.OnLateral;
                @Lateral.canceled -= m_Wrapper.m_ScooterActionsCallbackInterface.OnLateral;
            }
            m_Wrapper.m_ScooterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Lateral.started += instance.OnLateral;
                @Lateral.performed += instance.OnLateral;
                @Lateral.canceled += instance.OnLateral;
            }
        }
    }
    public ScooterActions @Scooter => new ScooterActions(this);
    public interface IScooterActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnLateral(InputAction.CallbackContext context);
    }
}
