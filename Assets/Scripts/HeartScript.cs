using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
