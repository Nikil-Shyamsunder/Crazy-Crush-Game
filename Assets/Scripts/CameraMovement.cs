using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;
    public float speedMultiplier;
    public float multiplyDuration;
    private float timeBeforeMultiplying;

    void Start()
    {
        timeBeforeMultiplying = Time.time + multiplyDuration;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("CM: " + Time.time);
        if (Time.time > timeBeforeMultiplying)
        {
            cameraSpeed *= (1+speedMultiplier);
            timeBeforeMultiplying = Time.time + multiplyDuration;
        }
        transform.position += new Vector3(cameraSpeed * Time.deltaTime, 0, 0);
    }
}
