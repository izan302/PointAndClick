using System.Collections;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    [SerializeField] private float m_Speed = 5f;
    private bool isMoving = false;
    public Transform m_FootTransform { get; private set; }
    private Coroutine moveCoroutine;

    void Start()
    {
        m_FootTransform = transform.Find("FeetPivot");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 l_MousePos = InputManager.Instance.GetWorldMousePosition();
            if (float.IsInfinity(l_MousePos.x) || float.IsNaN(l_MousePos.x)) return;

            float l_VerticalOffset = Vector3.Distance(transform.position, m_FootTransform.position);
            Vector3 l_TargetPosition = new Vector3(l_MousePos.x, l_MousePos.y + l_VerticalOffset, transform.position.z);
            
            if (moveCoroutine != null) StopCoroutine(moveCoroutine);
            moveCoroutine = StartCoroutine(Moving(l_TargetPosition));

        }
    }
    IEnumerator Moving(Vector3 targetPosition)
    {
        isMoving = true;
        while (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, m_Speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, targetPosition) < 0.05f)
            {
                isMoving = false;
            }
            yield return null;
        }

    }
}