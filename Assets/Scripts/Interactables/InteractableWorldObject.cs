using UnityEngine;

public class InteractableWorldObject : MonoBehaviour
{
    [SerializeField] private InteractableBase m_Data;
    [SerializeField] protected Transform m_WalkToPoint;
    void Start()
    {
        if (m_WalkToPoint == null) m_WalkToPoint = transform.Find("WalkToPoint");
    }

    void OnMouseOver()
    {
        if (m_Data != null)
            Debug.Log($"In Hotspot: {m_Data.InteractbleName}");
        else
            Debug.LogWarning($"Missing Scriptable Object on {gameObject.name}!");
    }
    void OnMouseExit()
    {
        if (m_Data != null)
            Debug.Log($"Out Hotspot: {m_Data.InteractbleName}");
        else
            Debug.LogWarning($"Missing Scriptable Object on {gameObject.name}!");
    }
}
