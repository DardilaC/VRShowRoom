using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AutoScaler : MonoBehaviour
{
    [SerializeField] private float defaultHeight = 1;
    [SerializeField] Camera m_camera;
    private float minHeight=0f;

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

    private void Start()
    {

    }

    void Resize()
    {

        float headHeight = m_camera.transform.localPosition.y;
        float scale = headHeight / defaultHeight ;
        transform.localScale = Vector3.one * scale;

        Debug.Log("" + transform.localScale);

    }

    /*void ReScale() {

        float scale = defaultHeight - minHeight;
        float headHeight = camera.transform.localPosition.y;
        transform.localScale = Vector3.one * scale;

    }*/

    IEnumerator ScaleWaiter()
    {

        yield return new WaitForSeconds(3);
        Resize();
    }
    public void OnEnable()
    {
        StartCoroutine(ScaleWaiter());

    }
    private void Update()
    {


    }
}
