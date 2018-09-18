using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField]
    private float enemySpeed = 3f;
    [SerializeField]
    private float rangeOfYMovemnt = 2f;

    private int direction = 1;
    private Vector3 initialPos;
    

    private void Start()
    {
        initialPos = transform.position;
    }

    private void Update()
    {
        float factor = direction == -1 ? 2f : 1;
        float movementOnYAxis = factor * enemySpeed * Time.deltaTime * direction;

        float newYPosition = transform.position.y + movementOnYAxis;

        if(Mathf.Abs((newYPosition - initialPos.y)) > rangeOfYMovemnt)
        {
            direction *= -1;
        }
        else
        {
            transform.position += new Vector3(0, movementOnYAxis, 0);
        }
    }
}