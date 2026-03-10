using UnityEngine;

public abstract class InteractableBase : MonoBehaviour
{
    [SerializeField] protected Transform m_WalkToPoint;
    void Start()
    {
        if (m_WalkToPoint == null) m_WalkToPoint = transform.Find("WalkToPoint");
    }
    
    public virtual void OnGive()
    {
        
    }
    public abstract void OnPickUp();
    public abstract void OnUse();
    
    public abstract void OnOpen();
    public abstract void OnLookAt();
    public abstract void OnPush();

    public abstract void OnClose();
    public abstract void OnTalkTo();
    public abstract void OnPull();

}
