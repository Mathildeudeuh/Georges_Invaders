using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMoveSin : MonoBehaviour
{
    float sinCenterY;
    public float frequency;
    public float amplitude;

    public bool inverted = false;
    void Awake()
    {
        sinCenterY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Vector2 pos = transform.position;
        
        float sin = Mathf.Sin(pos.x * frequency) * amplitude;
        if(inverted)
        {
            sin *= -1;
        }
        pos.y = sinCenterY + sin;

        transform.position = pos;
    }
}
