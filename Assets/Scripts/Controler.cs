using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum Direccion
{
    Arriba,
    Derecha,
    Izquierda,
    Zero
}
public class Controler : MonoBehaviour
{

    Vector2 Axis;
    public Vector2 axis
    {
        get
        {
            return Axis;
        }
    }
    public float Horizontal
    {
        get
        {
            return Axis.x;
        }
    }
    public float vertical
    {
        get
        {
            return Axis.y;
        }
    }

    public bool isMoving
    {
        get
        {
            return Axis != Vector2.zero;
        }
    }
    public void ModificarToque(Direccion dir)
    {
        switch (dir){
            case Direccion.Arriba:
                Axis = new Vector2(0, 1);
                break;
                
            case Direccion.Derecha: 
                Axis = new Vector2(1, 0);
                break;
            case Direccion.Izquierda: Axis = new Vector2(-1, 0);
                break;
            case Direccion.Zero:
                
                Axis = Vector2.zero;
                break;

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
