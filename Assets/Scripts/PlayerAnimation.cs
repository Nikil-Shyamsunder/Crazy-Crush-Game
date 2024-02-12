using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Sprite[] runningSprites; // Array to hold the running sprites
    public float animationSpeed = 0.1f; // Time in seconds for each sprite frame
    public Vector3 scaleUpFactor = new Vector3(1.2f, 1.2f, 1); // Scale factor to enlarge the sprite

    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer component
    private int currentSpriteIndex = 0; // Track the current sprite index
    private float timer; // Timer to track the time since the last sprite change

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
        transform.localScale = transform.localScale * 3; // Scale up the sprite initially
    }

    void Update()
    {
        timer += Time.deltaTime; // Update the timer with the time passed since the last frame

        if (timer >= animationSpeed) // Check if it's time to update the sprite
        {
            currentSpriteIndex++; // Move to the next sprite
            if (currentSpriteIndex >= runningSprites.Length) // Loop back to the first sprite if at the end
            {
                currentSpriteIndex = 0;
            }

            spriteRenderer.sprite = runningSprites[currentSpriteIndex]; // Update the sprite
            timer = 0f; // Reset the timer
        }
    }
}
