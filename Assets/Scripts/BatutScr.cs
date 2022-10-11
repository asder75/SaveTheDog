using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatutScr : MonoBehaviour
{
    [SerializeField]
    private float _power;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var rb = collision.gameObject.GetComponent<Rigidbody2D>();
        float t;
        Vector3 v;
        transform.rotation.ToAngleAxis(out t, out v);
        rb.velocity = new Vector2(-v.z * _power, Mathf.Abs(rb.velocity.y) + _power);
    }
}
