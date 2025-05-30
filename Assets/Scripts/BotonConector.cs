using UnityEngine;
using UnityEngine.UI;

public class BotonConector : MonoBehaviour
{
    public Button miBoton;
    public Dialogue dialogueScript;

    void Start()
    {
        miBoton.onClick.AddListener(dialogueScript.ActivarInteraccionDesdeBoton);
    }
}
