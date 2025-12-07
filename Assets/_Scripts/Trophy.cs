using UnityEngine;

public class Trophy : MonoBehaviour
{

    public float speed = 100f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
