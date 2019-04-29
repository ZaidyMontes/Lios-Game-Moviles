
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Botones : MonoBehaviour
{
    Controler Padre;
    public Direccion direction;
    // Start is called before the first frame update
    void Start()
    {
        Padre = GetComponentInParent<Controler>();
    }

    public void OnPointerEnter(PointerEventData p)
    {
        Padre.ModificarToque(direction);
    }
    public void OnPointerExit(PointerEventData p)
    {
        Padre.ModificarToque(Direccion.Zero);
    }
}