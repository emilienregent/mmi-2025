using UnityEngine;

public class ProximitySensor : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("� l'interieur");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Vous �tes sorti");
    }
}