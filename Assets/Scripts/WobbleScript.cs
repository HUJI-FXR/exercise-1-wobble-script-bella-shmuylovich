using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleScript : MonoBehaviour
{
    void Update()
    {
        transform.localPosition = new Vector3(
                Mathf.Sin(0.1f * Time.time),
                Mathf.Sin(3.616f * Time.time),
                Mathf.Sin(0.3f * Time.time));
        transform.localScale = new Vector3(
            Mathf.Sin(0.4f * Time.time), 
            Mathf.Sin(3f * Time.time),
            Mathf.Sin(1.6f * Time.time));
        transform.Rotate(new Vector3(
            Mathf.Sin(1.11f * Time.time), 
            Mathf.Sin(1f * Time.time), 
            Mathf.Sin(0.9f * Time.time)));
        GetComponent<Rigidbody>().mass = Mathf.Sin(Mathf.PI * Time.time);
    }
}
