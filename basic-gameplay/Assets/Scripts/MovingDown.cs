using UnityEngine;

public class MovingDown : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.AddForce(Vector3.forward * -this.speed);
    }
}
