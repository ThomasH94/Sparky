// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Entities/Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Input : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""playerControls"",
            ""id"": ""bc1d1dba-a1d1-4c8d-a223-2255878135b1"",
            ""actions"": [
                {
                    ""name"": ""directional"",
                    ""type"": ""Value"",
                    ""id"": ""c48ba95b-f856-44c3-9247-17ffc0c6f5d5"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""633c0fbd-b2d4-42ae-9df7-7e57c23fbf65"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""use1"",
                    ""type"": ""Button"",
                    ""id"": ""2223a736-5978-4286-a444-c4d72379fcfa"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""use2"",
                    ""type"": ""Button"",
                    ""id"": ""81138fb6-2756-4d9a-942a-bbf96f35d2a6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""use3"",
                    ""type"": ""Button"",
                    ""id"": ""33d76cc5-33be-4e59-8a58-c8c9a9dd46b2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""use4"",
                    ""type"": ""Button"",
                    ""id"": ""95f365d6-476e-412d-ac7c-34a06e16936a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""use5"",
                    ""type"": ""Button"",
                    ""id"": ""8896975f-74c9-41fc-af1d-cad49f9c9b0d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""use6"",
                    ""type"": ""Button"",
                    ""id"": ""a277e0a0-7364-4739-bb09-bb30b4d4ddf9"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""bb412eed-49f2-4d7f-8dbd-6565c5cf06a0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""axis"",
                    ""id"": ""a3ffd578-01bb-4ea3-bab6-947d253fbf88"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""directional"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""42849b77-1413-412c-8f7e-204a87c26e08"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""directional"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3effb5f2-6dab-4e94-8bfe-f0a55dbac327"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""directional"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ccd7387f-f781-41ea-aae8-b7a2bff47f28"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""directional"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""672ae015-3732-4c72-a642-8f300423b0d7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""directional"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fbcb19fb-5523-4a98-ab40-4a9877182269"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb684552-6e69-4d3d-bccd-0a8ec659029c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""use1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""679a209d-a3e4-44a6-9b5b-519fe388f0fa"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""use2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ebff7ee8-e78a-413b-a31a-a495b993c8d6"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""use3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a2bf74fc-c146-42fb-a85b-222cc045b85c"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""use4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a157e44-91ff-401f-b7a3-1b1b6605cf0e"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""use5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ccc9798-f22f-4b0f-831d-b4d52dcd8aed"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""use6"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d988135b-3b3a-42fd-a9bc-031418dd2aae"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""userInterface"",
            ""id"": ""aec99fb3-3b8d-44fe-9354-9bb4be6bcf8b"",
            ""actions"": [
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""3e089a59-f924-4cba-b5a0-30a254d0c66a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""da34569f-bc44-4f37-9e15-210674b7d1ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""eed9a902-d024-418b-9ed8-2ba0a4e6dad5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""35ea8dea-d393-41b6-b3e4-c12af6cde17d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2d58f4c3-b3a7-4924-8893-f6982b60e376"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f708273a-0d83-4d5d-a1e8-0e6601add8ff"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3c60c54e-32ac-4911-b83e-f1ac557e2317"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c70c7abe-45ec-402c-aa4e-033b4e3c2147"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""db1ed822-1005-45ca-84ca-c46ca4b43e2b"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fbd97bc9-242a-4343-89fe-1af4cb715d3c"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceSelect"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fbb46df1-90c1-44a7-96f8-d10274dc9120"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""730f9f00-6075-4b0d-bf37-f89c458c0cfc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b8f8694f-d715-4dfd-958d-8b1314136f14"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0b98592a-8c5b-4c3f-aa90-25ee99761647"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""68bf772b-c33f-47de-a477-7e9c0fa071d9"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""899fd691-7374-47c9-a9b3-4672bc94cc15"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""eb8a7b69-8da6-4215-8565-841dfb3ed06a"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""33773bd6-3136-4896-ad57-c632a6b70494"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""dc66d3b3-275c-4e53-8605-d081cdee9aea"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3a14306d-a672-4759-859e-85df386df366"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c4ca46cf-caa2-45e7-9c97-aee5e6091340"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""10d3240f-fbdf-4e51-983e-18e0fc3cfb45"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5c4f38d6-35ba-42ae-b7ca-7162463d5f7e"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""73452ac1-a6e4-4551-aae8-6940a1de49d5"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""c975a276-c10a-49e3-8dcf-b88e2da6096c"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""562ffbb1-501c-4202-ae53-e2461827bc62"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""e380a618-8765-4103-b83a-1cd6f9ef0bac"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1fe3f7b2-5522-421f-b3ce-bb39b647ca80"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ecce09f0-9127-40c1-b2dc-a4888ffc8170"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3a2d1a0f-85e5-411d-bec2-58be5dc2678c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5dd85970-1315-4eba-b77b-ffeea7406507"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4afe664a-e5e0-4f45-a9c3-2828faff0c3c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6ae5b78a-b72d-49d1-88a1-415fd357416b"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4ed4c3b4-3cb7-42df-8d42-b74e6e9f8d1b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""41aa6402-1ddb-45a2-a561-d6541664449f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c704293b-1bde-411c-b481-2dec1208e6b9"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b99b9dd0-224b-434d-8f47-31232e78fa11"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""65224ede-f864-42b8-8e61-12232ee6608f"",
                    ""path"": ""<Pointer>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""52831526-c5c4-4b4a-96b4-9f600e3ade9e"",
                    ""path"": ""<Touchscreen>/touch*/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b39118f4-38cd-4fd4-9d6f-c4ab502900ae"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b148ffb3-b037-4832-a31f-e62acbafe5c4"",
                    ""path"": ""<Pen>/tip"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff4fb61a-4b57-4572-b991-aef457ec536e"",
                    ""path"": ""<Touchscreen>/touch*/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Touch"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""217b63dd-5488-42e4-8309-fd589fb33089"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d2c24115-cd07-4538-8d56-c6ea434feaa6"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff30d94b-174e-463e-8c38-d97c68303e82"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8a58978-2a23-4799-9372-5d3110242654"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b51e154-fa65-4afb-86d6-0150ebbbf6a9"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6bdbf0d-d688-4897-a484-158062f8f5f7"",
                    ""path"": ""<XRController>/trigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceSelect"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // playerControls
        m_playerControls = asset.FindActionMap("playerControls", throwIfNotFound: true);
        m_playerControls_directional = m_playerControls.FindAction("directional", throwIfNotFound: true);
        m_playerControls_jump = m_playerControls.FindAction("jump", throwIfNotFound: true);
        m_playerControls_use1 = m_playerControls.FindAction("use1", throwIfNotFound: true);
        m_playerControls_use2 = m_playerControls.FindAction("use2", throwIfNotFound: true);
        m_playerControls_use3 = m_playerControls.FindAction("use3", throwIfNotFound: true);
        m_playerControls_use4 = m_playerControls.FindAction("use4", throwIfNotFound: true);
        m_playerControls_use5 = m_playerControls.FindAction("use5", throwIfNotFound: true);
        m_playerControls_use6 = m_playerControls.FindAction("use6", throwIfNotFound: true);
        m_playerControls_Interact = m_playerControls.FindAction("Interact", throwIfNotFound: true);
        // userInterface
        m_userInterface = asset.FindActionMap("userInterface", throwIfNotFound: true);
        m_userInterface_Navigate = m_userInterface.FindAction("Navigate", throwIfNotFound: true);
        m_userInterface_Submit = m_userInterface.FindAction("Submit", throwIfNotFound: true);
        m_userInterface_Cancel = m_userInterface.FindAction("Cancel", throwIfNotFound: true);
        m_userInterface_Point = m_userInterface.FindAction("Point", throwIfNotFound: true);
        m_userInterface_Click = m_userInterface.FindAction("Click", throwIfNotFound: true);
        m_userInterface_ScrollWheel = m_userInterface.FindAction("ScrollWheel", throwIfNotFound: true);
        m_userInterface_MiddleClick = m_userInterface.FindAction("MiddleClick", throwIfNotFound: true);
        m_userInterface_RightClick = m_userInterface.FindAction("RightClick", throwIfNotFound: true);
        m_userInterface_TrackedDevicePosition = m_userInterface.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_userInterface_TrackedDeviceOrientation = m_userInterface.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        m_userInterface_TrackedDeviceSelect = m_userInterface.FindAction("TrackedDeviceSelect", throwIfNotFound: true);
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

    // playerControls
    private readonly InputActionMap m_playerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_playerControls_directional;
    private readonly InputAction m_playerControls_jump;
    private readonly InputAction m_playerControls_use1;
    private readonly InputAction m_playerControls_use2;
    private readonly InputAction m_playerControls_use3;
    private readonly InputAction m_playerControls_use4;
    private readonly InputAction m_playerControls_use5;
    private readonly InputAction m_playerControls_use6;
    private readonly InputAction m_playerControls_Interact;
    public struct PlayerControlsActions
    {
        private @Input m_Wrapper;
        public PlayerControlsActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @directional => m_Wrapper.m_playerControls_directional;
        public InputAction @jump => m_Wrapper.m_playerControls_jump;
        public InputAction @use1 => m_Wrapper.m_playerControls_use1;
        public InputAction @use2 => m_Wrapper.m_playerControls_use2;
        public InputAction @use3 => m_Wrapper.m_playerControls_use3;
        public InputAction @use4 => m_Wrapper.m_playerControls_use4;
        public InputAction @use5 => m_Wrapper.m_playerControls_use5;
        public InputAction @use6 => m_Wrapper.m_playerControls_use6;
        public InputAction @Interact => m_Wrapper.m_playerControls_Interact;
        public InputActionMap Get() { return m_Wrapper.m_playerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @directional.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDirectional;
                @directional.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDirectional;
                @directional.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnDirectional;
                @jump.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnJump;
                @use1.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse1;
                @use1.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse1;
                @use1.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse1;
                @use2.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse2;
                @use2.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse2;
                @use2.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse2;
                @use3.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse3;
                @use3.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse3;
                @use3.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse3;
                @use4.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse4;
                @use4.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse4;
                @use4.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse4;
                @use5.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse5;
                @use5.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse5;
                @use5.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse5;
                @use6.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse6;
                @use6.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse6;
                @use6.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnUse6;
                @Interact.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @directional.started += instance.OnDirectional;
                @directional.performed += instance.OnDirectional;
                @directional.canceled += instance.OnDirectional;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @use1.started += instance.OnUse1;
                @use1.performed += instance.OnUse1;
                @use1.canceled += instance.OnUse1;
                @use2.started += instance.OnUse2;
                @use2.performed += instance.OnUse2;
                @use2.canceled += instance.OnUse2;
                @use3.started += instance.OnUse3;
                @use3.performed += instance.OnUse3;
                @use3.canceled += instance.OnUse3;
                @use4.started += instance.OnUse4;
                @use4.performed += instance.OnUse4;
                @use4.canceled += instance.OnUse4;
                @use5.started += instance.OnUse5;
                @use5.performed += instance.OnUse5;
                @use5.canceled += instance.OnUse5;
                @use6.started += instance.OnUse6;
                @use6.performed += instance.OnUse6;
                @use6.canceled += instance.OnUse6;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public PlayerControlsActions @playerControls => new PlayerControlsActions(this);

    // userInterface
    private readonly InputActionMap m_userInterface;
    private IUserInterfaceActions m_UserInterfaceActionsCallbackInterface;
    private readonly InputAction m_userInterface_Navigate;
    private readonly InputAction m_userInterface_Submit;
    private readonly InputAction m_userInterface_Cancel;
    private readonly InputAction m_userInterface_Point;
    private readonly InputAction m_userInterface_Click;
    private readonly InputAction m_userInterface_ScrollWheel;
    private readonly InputAction m_userInterface_MiddleClick;
    private readonly InputAction m_userInterface_RightClick;
    private readonly InputAction m_userInterface_TrackedDevicePosition;
    private readonly InputAction m_userInterface_TrackedDeviceOrientation;
    private readonly InputAction m_userInterface_TrackedDeviceSelect;
    public struct UserInterfaceActions
    {
        private @Input m_Wrapper;
        public UserInterfaceActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Navigate => m_Wrapper.m_userInterface_Navigate;
        public InputAction @Submit => m_Wrapper.m_userInterface_Submit;
        public InputAction @Cancel => m_Wrapper.m_userInterface_Cancel;
        public InputAction @Point => m_Wrapper.m_userInterface_Point;
        public InputAction @Click => m_Wrapper.m_userInterface_Click;
        public InputAction @ScrollWheel => m_Wrapper.m_userInterface_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_userInterface_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_userInterface_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_userInterface_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_userInterface_TrackedDeviceOrientation;
        public InputAction @TrackedDeviceSelect => m_Wrapper.m_userInterface_TrackedDeviceSelect;
        public InputActionMap Get() { return m_Wrapper.m_userInterface; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UserInterfaceActions set) { return set.Get(); }
        public void SetCallbacks(IUserInterfaceActions instance)
        {
            if (m_Wrapper.m_UserInterfaceActionsCallbackInterface != null)
            {
                @Navigate.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnSubmit;
                @Cancel.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnCancel;
                @Point.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnClick;
                @ScrollWheel.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceSelect.started -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnTrackedDeviceSelect;
                @TrackedDeviceSelect.performed -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnTrackedDeviceSelect;
                @TrackedDeviceSelect.canceled -= m_Wrapper.m_UserInterfaceActionsCallbackInterface.OnTrackedDeviceSelect;
            }
            m_Wrapper.m_UserInterfaceActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceSelect.started += instance.OnTrackedDeviceSelect;
                @TrackedDeviceSelect.performed += instance.OnTrackedDeviceSelect;
                @TrackedDeviceSelect.canceled += instance.OnTrackedDeviceSelect;
            }
        }
    }
    public UserInterfaceActions @userInterface => new UserInterfaceActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnDirectional(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnUse1(InputAction.CallbackContext context);
        void OnUse2(InputAction.CallbackContext context);
        void OnUse3(InputAction.CallbackContext context);
        void OnUse4(InputAction.CallbackContext context);
        void OnUse5(InputAction.CallbackContext context);
        void OnUse6(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IUserInterfaceActions
    {
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
        void OnTrackedDeviceSelect(InputAction.CallbackContext context);
    }
}
