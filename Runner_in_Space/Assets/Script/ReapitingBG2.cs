using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReapitingBG2 : MonoBehaviour
{
    public float _speed;

    public float endy;
    public float starty;

    private void Update()
    {
        transform.Translate(Vector2.right * _speed * Time.deltaTime);

        if (transform.position.x <= endy)
        {
            Vector2 pos = new Vector2(starty, transform.position.y);
            transform.position = pos;
        }
    }
}
