using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int ballCount;
    public Rigidbody2D ball;
    public float minForce;
    public float maxForce;
    public float directionSpeed;

    public void StartGame ()
    {
        for (int i = 0; i < ballCount; i++) 
        {
            float directionX = Mathf.Round(Random.Range(-directionSpeed, directionSpeed) * 100.0f) * 0.01f;
            float directionY = Mathf.Round(Random.Range(-directionSpeed, directionSpeed) * 100.0f) * 0.01f;

            Debug.Log($"direction x: {directionX}");
            Debug.Log($"== direction y: {directionY}");
            if (directionX == 0.0f && directionY == 0.0f)
            {
                directionX = -directionSpeed;
            } 

           var force = Mathf.Round(Random.Range(minForce, maxForce) * 100.0f) * 0.01f;
            // else if (directionX > 0.0f && directionX < -0.5f && directionY < 0.3f) 
            // {
            //     directionX = directionSpeed;
            // }
            float value = (float)((Mathf.Atan2(directionX, directionY) / Mathf.PI) * 180f);
     if(value < 0) value += 360f;
            Rigidbody2D ballObject;
            // ballObject = Instantiate(ball, gameObject.transform.position, Quaternion.Euler(0.0f, 0.0f, i)) as Rigidbody2D ;
            // ballObject.AddForce(new Vector2(directionX, directionY) * force);
            // ballObject = Instantiate(ball, gameObject.transform.position, Quaternion.Euler(directionX, directionY, i)) as Rigidbody2D ;
            // ballObject.AddForce(ballObject.transform.forward * force);
            ballObject = Instantiate(ball, gameObject.transform.position, Quaternion.Euler(0.0f, 0.0f, value)) as Rigidbody2D ;
            ballObject.AddForce(ballObject.transform.right * force);

            // var go = Instantiate(ball, gameObject.transform.position, Quaternion.Euler(0.0f, 0.0f, i));
            // go.GetComponent<Rigidbody>().AddForce(go.transform.forward * force);
        }
    }


}
