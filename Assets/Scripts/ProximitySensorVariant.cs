using UnityEngine;

public class ProximitySensorVariant : MonoBehaviour
{

    private const string PLAYER_TAG = "Player";

    [SerializeField] float m_Distance = 2f;

    Transform m_Target;
    float m_SqrDistance;
    bool m_IsTargetWithinDistane = false;
    // il manque le reste
}