using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
    private CameraMovement camera;
    public Vector2 cameraChange;
    public Vector3 playerChange;

    // Start is called before the first frame update
    void Start()
    {
        camera = Camera.main.GetComponent<CameraMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            camera.minPosition += cameraChange;
            camera.maxPosition += cameraChange;
            other.transform.position += playerChange;
        }
    }
}
