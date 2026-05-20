using UnityEngine;

public class DeplacementPoisson : MonoBehaviour
{
    public Vector2 direction;
    public float vitesse;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(direction * vitesse);
        rb.linearVelocityX = Mathf.Clamp(rb.velocity.x, -2, -2);
        if (transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
