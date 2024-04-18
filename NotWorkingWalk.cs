using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Car : MonoBehaviour
{
    [SerializeField] float speed = 20;
    [SerializeField] float waitTime = 1;
    private Rigidbody rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        transform.position += Input.GetAxisRaw("Vertical") * transform.forward * speed * Time.deltaTime;
        Vector3 movement = new Vector3(0, 0.0f, 0);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(Runtime());
        }
    }
    IEnumerator Runtime()
    {
        speed = 50;
        yield return new WaitForSeconds(waitTime/10);
        speed = 20;
    }
}