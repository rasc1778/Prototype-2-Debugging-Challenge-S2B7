using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] string axisName = "Set Input Axis";
    [SerializeField] float speed = 10.0f;
    [SerializeField] float bound = 12.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    [SerializeField] float horizontalInput;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis(axisName);
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);

        if (transform.position.x < -bound) {
            transform.position = new Vector3(-bound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > bound) {
            transform.position = new Vector3(bound, transform.position.y, transform.position.z);
        }
    }
}
