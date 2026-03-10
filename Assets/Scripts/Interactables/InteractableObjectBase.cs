using UnityEngine;

public class InteractableBase : ScriptableObject
{
    [Header("Configuración Visual")]
    public string nombreObjeto;
    public string descripcion;
    
    public virtual void OnLookAt() => Debug.Log($"Ves un {nombreObjeto}: {descripcion}");
    public virtual void OnUse() => DefaultInteraction("Can't use that");
    public virtual void OnPickUp() => DefaultInteraction("recoger");
    public virtual void OnOpen() => DefaultInteraction("abrir");
    public virtual void OnTalkTo() => DefaultInteraction("hablar con");
    public virtual void OnPush() => DefaultInteraction("empujar");
    public virtual void OnPull() => DefaultInteraction("tirar de");
    public virtual void OnGive() => DefaultInteraction("dar");

    protected void DefaultInteraction(string accion) 
    {
        Debug.Log($"No tiene sentido intentar {accion} el objeto {nombreObjeto}.");
    }
}
