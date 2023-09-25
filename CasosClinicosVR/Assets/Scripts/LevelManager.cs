using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Obj puede estar vacio, nulo, con info
public enum LevelState
{
  INTRO,
  REVISION, 
  CHECKING,
  RESULTS,
  END
}

public enum Casos_Diagnostico
{
  CASO_0 = 0,
  CASO_1 = 1,
  CASO_2 = 2,
  CASO_3 = 3,
}

public class LevelManager : MonoBehaviour
{
  public static LevelManager instance;

  public LevelState levelState;

  public Casos_Diagnostico diagnostico;
  public Casos_Diagnostico diagnosticoIncorrecto;
  public Casos_Diagnostico diagnosticoCorrecto;
  public bool IsOxygenOk = false;
  public bool IsTemperatureOk = false;
  public bool IsPulseOk = false;

  public void setDiagnostico()
  {
    if (IsOxygenOk == true && IsTemperatureOk == true && IsPulseOk == true)
    {
      // Info
    }
    if (IsOxygenOk == true && IsTemperatureOk == true && IsPulseOk == false)
    {
      // Info
    }
    if (IsOxygenOk == true && IsTemperatureOk == false && IsPulseOk == false)
    {
      // Info
    }if (IsOxygenOk == true && IsTemperatureOk == false && IsPulseOk == true)
    {
      // Info
    }
  }

  private void Awake()
  {
    if (instance != null)
    {
      Debug.Log("Level Manager: Instance ya tiene informacion");
      return;
    }
    else
    {
      Debug.Log("Level Manager: Instance NO tiene informacion");
      instance = this;
    }
  }

  // Start is called before the first frame update
  void Start()
  {
    // Definir el caso correcto que tendra el nivel
    int rand = Random.Range(0, 7);

    switch (rand)
    {
      case 0:
        diagnosticoCorrecto = Casos_Diagnostico.CASO_0;
        break;
      case 1:
        diagnosticoCorrecto = Casos_Diagnostico.CASO_1;
        break;
      default:
        break;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }
}
