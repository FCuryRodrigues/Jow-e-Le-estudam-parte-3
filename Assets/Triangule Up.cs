using UnityEngine;

public class TrianguleUp : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    [SerializeField]
    private float verticalSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButton(0)))
        {
            FlyUp();
        }
    }
    private void FlyUp()
    {
        myRigidbody.linearVelocity = Vector2.up * verticalSpeed;
    }
}
