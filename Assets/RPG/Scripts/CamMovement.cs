using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform follow;
    public float boundx = 0.3f;
    public float boundy = 0.15f;


    

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        float deltaX = follow.position.x - transform.position.x;

        if (deltaX > boundx || deltaX < -boundx)
        {
            if (transform.position.x < follow.position.x)
            {

                delta.x = deltaX - boundx;

            }
            else
            {
                delta.x = deltaX + boundx;
            }

        }
        float deltaY = follow.position.y - transform.position.y;

        if (deltaY > boundy || deltaY < -boundy)
        {
            if (transform.position.y < follow.position.y)
            {

                delta.y = deltaY - boundy;

            }
            else
            {
                delta.y = deltaY + boundy;
            }

        }

        transform.position += new Vector3(delta.x, delta.y, 0);

    }
}
