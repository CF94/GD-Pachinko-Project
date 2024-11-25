using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class TestScript : MonoBehaviour
{
    public float moveSpeed = 10;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerMovement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        transform.Translate(playerMovement * moveSpeed *  Time.deltaTime);
    }

}
