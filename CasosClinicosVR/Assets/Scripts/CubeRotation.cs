using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
  // Variables -> Tipo de dato + Nombre + simbolo de Asignación + valor a asignar + ;
  public int edad = 15;
  public float altura = 1.83f;
  public string nombre = "Roberto";
  public char letras = 'l';
  public bool IsDoorOpen = false;

  private Rigidbody rb;
  public bool hasGravity = false;
  // Function -> 
  void setNombre()
  {
    // Logica
  }

  void setNombre(string _nombre)
  {
    nombre = _nombre;
  }

  void setRotationOfCube()
  {
    transform.Rotate(Vector3.up * 30 * Time.deltaTime);
  }

  float getAltura()
  {
    // Logica
    return altura;
  }

  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>(); // Busca dentro del objeto a ver si exite dicho componente
    // Inicializacion de recursos
    Debug.Log("Hola, esto es una prueba funcion llamada Start()");
  }

  // Update is called once per frame
  void Update()
  {
    if (LevelManager.instance.levelState == LevelState.CHECKING)
    {
      Debug.Log("El level state se encuentra en el estado de CHECKING");
    }

    // Actualizacion logica y visual
    rb.useGravity = hasGravity;

    //Debug.Log("Actualizacion de la funcion Update()");

    setRotationOfCube();
    
    //Debug.Log("La altura es: " + getAltura().ToString());
  }


}
