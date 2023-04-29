using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private const float AxisLimitZ = -20.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < AxisLimitZ)
        {
            Destroy(gameObject);
        }
    }
}
