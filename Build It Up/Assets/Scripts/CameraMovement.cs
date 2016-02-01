using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public float horizontalSpeed;
    public float verticalSpeed;
    public float cameraHight;
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(transform.position.x, cameraHight, transform.position.z);
        
        float horizontal = Input.GetAxis("Horizontal") * horizontalSpeed * Time.deltaTime;
        float vertical = Input.GetAxis("Vertical") * verticalSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * vertical, Space.World);
        transform.Translate(Vector3.right * horizontal, Space.World);
    }
}
