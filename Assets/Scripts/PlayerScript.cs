using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerScript : MonoBehaviour
{
    public float jumpForce;
    public float score = 0;
    bool isAlive = true;

    public int totalJumps;
    private int jumpsLeft;

    [SerializeField]
    private bool isGrounded = false;

    public TextMeshProUGUI scoreTxt;

    Rigidbody2D rb;

    public ParticleSystem particleSystemPrefab;

    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        jumpsLeft = totalJumps;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumpsLeft > 0){
                float scale = 1f;
                if (jumpsLeft == 1)
                {
                    scale = 0.75f; // second jump is slighly weaker
                }
                rb.velocity = new Vector3(rb.velocity.x, 0); // Reset Y velocity
                rb.AddForce(Vector2.up * jumpForce * scale);
                jumpsLeft -= 1;
                isGrounded = false;
            }
        } 

        if (isAlive)
        {
            score += Time.deltaTime * 4;
            scoreTxt.text= "SCORE: " + score.ToString(".");
        }
        
    }

    // jump! and also die
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("ground"))
        {
            if (!isGrounded){
                isGrounded = true; 
                jumpsLeft = 2;
            }
        }

        if (collision.gameObject.CompareTag("spike"))
        {
            Destroy(this.gameObject);
        }

        /*if (collision.gameObject.CompareTag("heart"))
        {
            //Debug.Log("Collidied with remove.");
            Destroy(collision.gameObject);
        } */

    }
   void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("heart"))
            {
                score += 10;
                Destroy(collision.gameObject); // Destroys the heart object
                //particleSystem.Play();
                Instantiate(particleSystemPrefab, transform.position, Quaternion.identity);
            }
        }


}
