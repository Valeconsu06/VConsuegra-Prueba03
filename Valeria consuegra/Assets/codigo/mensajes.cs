using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mensajes : MonoBehaviour
{
  public void mensaje1()
    {
        print("hola este es el mensaje 1");
    }

    public void mensaje2()
    {
        print("hola este es el mensaje 2");
    }

    public void mensaje3(string nombre)
    {
        print("hola" + nombre + ",¿como estas?");
    }
}


