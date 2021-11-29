using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float forceMagnitude;
    [SerializeField] private float maxVelocity;

    private Rigidbody rb;
    private Camera MainCamera;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        MainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Touchscreen.current.primaryTouch.press.isPressed)
        {
            Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
            Debug.Log(touchPosition);
            
            Vector3 worldPosition = MainCamera.WorldToScreenPoint(touchPosition);
            Debug.Log(worldPosition);
        }
    }
}
