using UnityEngine;

public class RotateCoin : MonoBehaviour
{

    public float rotateSpeed = 90;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotateSpeed) * Time.deltaTime);
    }
}
