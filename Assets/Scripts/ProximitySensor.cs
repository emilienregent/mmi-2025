using UnityEngine;

public class ProximitySensor : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("à l'interieur");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Vous êtes sorti");
    }
}