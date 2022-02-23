using UnityEngine;


public class MovingObject:MonoBehaviour
{
    private MainController _controller;
    private void Start()
    {

    }
    public void MoveFor(Vector2 delta)
    {
        transform.position+= new Vector3(delta.x,0,delta,y));
    }
    private void Update()
    {
        MoveFor(_controller.Value);
    }

}