using UnityEngine;
using UnityEngine.UIElements;

public class Spin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float moveSpeed = 10f;

    public Vector2 rotationChange;
    public Vector2 positionChange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, moveSpeed);
     }
}
