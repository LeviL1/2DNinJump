using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform pathstart;
    public Transform pathEnd;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Transfrom enemyTransfrom = GetComponent(Transform);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemyTransform.posistion = Vector2.MoveTowards(pathstart.posistion);
        if(Vector2.Distance(enemyTransform.posistion, pathstart) <= 0.2f)
        {
            enemyTransform.posistion = Vector2.MoveTowards(pathEnd);
        }
        else(Vector2.Distance(enemyTransform.posistion, pathstart) <= 0.2f)
        {
            enemyTransform.posistion = Vector2.MoveTowards(pathStart);
        }
    }
}
