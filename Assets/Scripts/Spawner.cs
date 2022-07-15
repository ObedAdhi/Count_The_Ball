using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int ballCount;
    public Rigidbody2D ball;
    public float force;

    public void StartGame ()
    {
        for (int i = 0; i < ballCount; i++) 
        {
            float directionX = Mathf.Round(Random.Range(-1.0f, 1.0f) * 10.0f) * 0.1f;
            float directionY = Mathf.Round(Random.Range(-1.0f, 1.0f) * 10.0f) * 0.1f;

            if (directionX < 0.0f && directionX > -0.5f && directionY < 0.3f)
            {
                directionX = -1.0f;
            } else if (directionX > 0.0f && directionX < -0.5f && directionY < 0.3f) 
            {
                directionX = 1.0f;
            }
            Rigidbody2D ballObject;
            ballObject = Instantiate(ball, gameObject.transform.position, Quaternion.Euler(0.0f, 0.0f, i)) as Rigidbody2D ;
            ballObject.AddForce(new Vector2(directionX, directionY) * force);
        }
    }


}
