using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class SpikeScript : MonoBehaviour
{
    //public LoopingBackground scrollingBackground;
    public float backgroundSpeed;

    void Start(){
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * backgroundSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log( "X" + collision.gameObject.tag + "Y");
        if (collision.gameObject.CompareTag("destroyLine"))
        {
            //Debug.Log("Collidied with remove.");
            Destroy(this.gameObject);
        }   
    }
}
