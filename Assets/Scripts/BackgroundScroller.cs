using UnityEngine;



public class BackgroundScvroll : MonoBehaviour
{
    public float speed = 2f;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
        if (transform.position.y < -16)
            transform.position = new Vector3(transform.position.x, transform.position.y + 16f, transform.position.z);
    }
}
