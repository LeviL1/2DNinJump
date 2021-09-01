using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
  public Transform[] wayPoints;
  public Transform pathStart;
  public Transform pathEnd;
  private Transform target;
  public Transform player;
  private float speed = 2;
  private int wayPointIndex = 0;
  private void Awake()
  {
    wayPoints = new Transform[2];
    wayPoints[0] = pathStart;
    wayPoints[1] = pathEnd;
  }
  // Start is called before the first frame update
  void Start()
  {

    
    target = wayPoints[0];
  }


  private void Update()
  {
    
    transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    if (Vector2.Distance(transform.position, target.position) <= 0.2f)
    {
      
      MoveStart();
      wayPointIndex++;
    }
    
    void MoveStart()
    {

      if (wayPointIndex == wayPoints.Length - 1) 
      {
        wayPointIndex -= 1;
      }
      
      target = wayPoints[wayPointIndex];
    }
    
  }

}
