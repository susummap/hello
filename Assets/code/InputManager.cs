using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInputActions Actions;
    public PlayerInputActions.PlayerActions Player => Actions.Player;
    public PlayerInputActions.UIActions UI => Actions.UI;
    
    // Start is called before the first frame update
    void Awake ()
    {
        Actions = new PlayerInputActions();
        Actions.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
