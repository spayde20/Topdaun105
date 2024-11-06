using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;


public class Controler : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform friePoint;
    [SerializeField] private LayerMask damageLayerMask;
    private Rigidbody2D _rd;
    private Camera _mainCamera;
    void Start()
    {
       _rd = GetComponent<Rigidbody2D>();
       _mainCamera = Camera.main;
    }

     void Update()
    {
        Move();
        Shoot();
    }

    private void Move()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 moveDirection =
        new Vector2(moveX, moveY).normalized;
        _rd.velocity = moveDirection * speed;
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePosition = _mainCamera.ScreenToWorldPoint(Input.mousePosition);
            mousePosition.z = 0;
            Vector2 direction = mousePosition - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            Quaternion bull
        }
    }
}
