using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum NodeState
{
    ready = 0,
    opened,
    closed
}
public class Node 
{
 private List<Node> _adjNodes = new List<Node>();
 bool _isObstacle = false;
 private Vector3 _position;

  
}
