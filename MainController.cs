using UnityEngine;
using System;

public class MainController:MonoBehaviour
{
    public Vector2 Value{ get{ return new Vector2(this._x,this._y); } }
    [Range(-1,1)]
    [SerializeField] private float _x=0f;
    [Range(-1,1)]
    [SerializeField] private float _y=0f;
    [SerializeField] private float _sensity=1f;

    private Vector2 _startCoords;
    private bool _isControlling=true;
    
    private void Start()
    {

    }
    
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _startCoords=Input.mousePosition;
            _isControlling=true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            _isControlling=false;
            _x=0;
            _y=0;
        }
        if(Input.GetMouseButton(0))
        {
            if(_isControlling)
            {
                var currentMousePos=Input.mousePosition;
                var xDelta=currentMousePos.x-_startCoords.x;
                var yDelta=currentMousePos.y-_startCoords.y;

                if(xDelta<=_sensity)
                {
                    _x= xDelta/_sensity;
                }else{
                    _x=1;
                }
                 if(yDelta<=_sensity)
                {
                    _y= yDelta/_sensity;
                }else{
                    y=1;
                }
            }
        }
    }

}