using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopingBackground : MonoBehaviour
{
    public float backgroundSpeed;
    public CameraMovement cm;
    public Renderer backgroundRenderer;
    private float timeBeforeMultiplying;
    // Start is called before the first frame update
    void Start()
    {
        timeBeforeMultiplying = Time.time + cm.multiplyDuration;
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log("LB: " + Time.time);
        Debug.Log("LB: " + cm.timeBeforeMultiplying);
        Debug.Log(Time.time > cm.timeBeforeMultiplying);*/
        if (Time.time > timeBeforeMultiplying)
        {
            Debug.Log("Updating");
            backgroundSpeed *= (1+cm.speedMultiplier);
            timeBeforeMultiplying = Time.time + cm.multiplyDuration;
        }
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }   
}
