using UnityEngine;
using UnityEngine.UIElements;

public class RandomizeSprite : MonoBehaviour
{
    public Sprite[] sprites; // Array to hold the sprite options
    public float scale;

    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
        transform.localScale = transform.localScale * scale; // Scale up the sprite initially
        RandomizeHeartSprite(); // Randomize the sprite on start
    
    }

    void RandomizeHeartSprite()
    {
        if (sprites.Length > 0)
        {
            int index = Random.Range(0, sprites.Length); // Select a random index
            spriteRenderer.sprite = sprites[index]; // Set the sprite to the randomly selected one
        }
    }
}
