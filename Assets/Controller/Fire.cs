// GENERATED AUTOMATICALLY FROM 'Assets/Controller/Fire.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Fire : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Fire()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Fire"",
    ""maps"": [
        {
            ""name"": ""Bullet"",
            ""id"": ""310b84bf-e9e1-4612-a38c-4f2e3904b901"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""8e597237-e7bc-45d2-9465-52ab3c40412b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d0545c82-ef29-46fe-b9c8-dc4b8f674f3c"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Bullet
        m_Bullet = asset.FindActionMap("Bullet", throwIfNotFound: true);
        m_Bullet_Shoot = m_Bullet.FindAction("Shoot", throwIfNotFound: true);
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

    // Bullet
    private readonly InputActionMap m_Bullet;
    private IBulletActions m_BulletActionsCallbackInterface;
    private readonly InputAction m_Bullet_Shoot;
    public struct BulletActions
    {
        private @Fire m_Wrapper;
        public BulletActions(@Fire wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Bullet_Shoot;
        public InputActionMap Get() { return m_Wrapper.m_Bullet; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BulletActions set) { return set.Get(); }
        public void SetCallbacks(IBulletActions instance)
        {
            if (m_Wrapper.m_BulletActionsCallbackInterface != null)
            {
                @Shoot.started -= m_Wrapper.m_BulletActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_BulletActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_BulletActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_BulletActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
            }
        }
    }
    public BulletActions @Bullet => new BulletActions(this);
    public interface IBulletActions
    {
        void OnShoot(InputAction.CallbackContext context);
    }
}
