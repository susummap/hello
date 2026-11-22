using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class CameraScroll : MonoBehaviour
{
    public Camera camerascroll;
    public InputManager inputmanager;
    // Update is called once per frame
    void Update()
    {
        if (camerascroll == null || inputmanager == null) return;
        var scroll = inputmanager.Player.Scroll.ReadValue<Vector2>();
        var y = camerascroll.orthographicSize + scroll.y * Time.deltaTime;
        camerascroll.orthographicSize = Mathf.Clamp(y,2,7);
    }
}
