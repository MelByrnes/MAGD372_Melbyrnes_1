using UnityEngine;

public class mouseLook : MonoBehaviour
{

    public float sensitivity = 100f;

    public Transform playerbody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        playerbody.Rotate(Vector3.up * mouseX);
    }
}
