using UnityEngine;

public abstract class InteractableWorldObject : MonoBehaviour
{
    [SerializeField] protected Transform m_WalkToPoint;
    void Start()
    {
        if (m_WalkToPoint == null) m_WalkToPoint = transform.Find("WalkToPoint");
    }

    void OnMouseOver()
    {
       
    }
    void OnMouseExit()
    {
        Debug.Log("Out Hotspot");
    }
}
