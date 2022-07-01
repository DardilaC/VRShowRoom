using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ReScaler : MonoBehaviour


{
    [SerializeField] XRController controller;
    [SerializeField] private float defaultHeight = 1.04277833f;
    [SerializeField] GameObject XROrigin;
    [SerializeField] Camera m_camera;
    [SerializeField] GameObject player;
    private float minHeight = 0f;
    
    public Camera camera
    {
        get => m_camera;
        set => m_camera = value;
    }

    private void Awake()
    {

        if (m_camera == null)
        {
            var mainCamera = Camera.main;
            if (mainCamera != null)
                m_camera = mainCamera;
        }
    }

    void Start()
    {

        
    }
    
    public bool isButtonPressed()
    {
        controller.inputDevice.TryGetFeatureValue(CommonUsages.secondaryButton, out bool isPressed);
        return isPressed;
    }


    void Update()
    {

        if (isButtonPressed() == true) {

            float headHeight = camera.transform.localPosition.y;
            float scale = headHeight / defaultHeight;
            player.gameObject.transform.localScale = Vector3.one * scale;
            XROrigin.gameObject.transform.localScale = Vector3.one * scale;

            Debug.Log("Si");

        } 
        
    }
}
