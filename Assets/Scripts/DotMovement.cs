using UnityEngine;
using UnityEngine.EventSystems;
public class DotMovement : MonoBehaviour, IDragHandler
{
    public float z = 0.0f;
    Rigidbody2D rigidBody;
    public LayerMask obstacleMask;
    void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = z;
        transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        UpdateVelObs();
    }

    public void UpdateVelObs()
    {
        if (transform.position.y >= 5)
        {
            Globle.velPos = Globle.velIni + 0.26f;
        }
        else
        {
            if (transform.position.y < 5 && transform.position.y >= 0)
            {
                Globle.velPos = Globle.velIni + 0.22f;
            }
            else
            {
                if (transform.position.y < 0 && transform.position.y >= -5)
                {
                    Globle.velPos = Globle.velIni + 0.18f;
                }
                else
                {
                    if (transform.position.y <= -5)
                    {
                        Globle.velPos = Globle.velIni + 0.14f;
                    }
                }
            }
        }
    }

    

}
