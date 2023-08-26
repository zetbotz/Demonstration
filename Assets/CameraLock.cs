using UnityEngine;

public class CameraLock : MonoBehaviour
{

    public Transform car;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = car.position + offset;
        float angle = Mathf.Atan((car.position.x - transform.position.x) / (car.position.z - transform.position.z));     
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, angle, transform.rotation.eulerAngles.z);
    }
}
