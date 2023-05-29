using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField]
    float speed;
    int angle;
    int maxAngle = 20;
    int minAngle = -60;
    public Score scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _rb.velocity = new Vector2(_rb.velocity.x, speed);
        }
        if(_rb.velocity.y > 0) 
        {
            if(angle <= maxAngle) 
            {
                angle = angle + 4;
            }
        }
        else if (_rb.velocity.y < -2.5)
        {
            if(angle >= minAngle) 
            {
                angle = angle - 2;
            }
        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            scoreScript.Scored();
        }
    }
    
}
