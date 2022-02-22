using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float maxRange;
    public bool move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (move)
            Move();
      

    }
    void Move()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * inputX * speed * Time.deltaTime;
        var xPros = Mathf.Clamp(transform.position.x, -maxRange, maxRange);
        transform.position = new Vector3(xPros, transform.position.y, transform.position.z);
    }
}
