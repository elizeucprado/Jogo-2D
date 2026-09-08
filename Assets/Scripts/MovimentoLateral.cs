using UnityEngine;

public class MovimentoLateral : MonoBehaviour
{

    public float speed = 5f;
    public float horizontal;

    void Start()
    {
        
    }

    
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        transform.position += Vector3.right * horizontal * speed * Time.deltaTime;
    }
}
