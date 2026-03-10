using UnityEngine;
[CreateAssetMenu(fileName = "NewInteractableType", menuName = "Interactables/New Interactable Type")]
public class InteractableBase : ScriptableObject
{
    public string InteractbleName;
    public string InteractableDescription;
    
    public virtual void OnLookAt() => Debug.Log($"Looks like a {InteractableDescription} {InteractbleName} to me.");
    public virtual void OnUse() => GameEvents.Instance.TriggerOnGive("I can't use that.");
    public virtual void OnPickUp() => GameEvents.Instance.TriggerOnPickUp("I can't use that.");
    public virtual void OnOpen() => GameEvents.Instance.TriggerOnOpen("Won't open.");
    public virtual void OnTalkTo() => GameEvents.Instance.TriggerOnTalkTo("Doesn't want to listen.");
    public virtual void OnPush() => GameEvents.Instance.TriggerOnPush("I can't push that.");
    public virtual void OnPull() => GameEvents.Instance.TriggerOnPull("I won't move.");
    public virtual void OnGive() => GameEvents.Instance.TriggerOnGive("I can't give that");
}
