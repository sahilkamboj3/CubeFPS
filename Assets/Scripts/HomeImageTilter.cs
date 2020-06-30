using UnityEngine;

public class HomeImageTilter : MonoBehaviour
{
    public float maxRatio;
    public float maxDegrees;
    public float zRotationSpeed;
    
    void Update()
    {
        transform.Rotate(new Vector3(0f, 0f, zRotationSpeed));
        if (Mathf.Abs(transform.rotation.z) >= maxRatio)
        {
            zRotationSpeed *= -1;
        }
    }
}
