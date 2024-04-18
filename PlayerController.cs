using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float waitTime = 1;
    private Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");

        rb.velocity = rb.velocity + (transform.forward * speed * moveVertical);
        


    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(Runtime());
        }

    }
    IEnumerator Runtime()
    {
        speed = 5;
        yield return new WaitForSeconds(waitTime / 10);
        speed = 2;
    }
}