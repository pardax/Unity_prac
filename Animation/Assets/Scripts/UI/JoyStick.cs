using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JoyStick : MonoBehaviour
{
    public Image joy;
    public GameObject player;

    Vector3 startPos;
    Vector3 direction;

    float limitDistance;
    float moveDistance;
    bool isDragging;

    // Start is called before the first frame update
    void Start()
    {
        startPos = joy.transform.position;
        limitDistance = joy.rectTransform.sizeDelta.x / 1.2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            Vector3 movement = new Vector3(direction.x, 0, direction.y);
            player.transform.Translate(movement.normalized * 5 * Time.deltaTime);
        }
    }

    public void OnDragEvent()
    {
        isDragging = true;
        Vector3 mousePos = Input.mousePosition;

        direction = (mousePos - startPos).normalized;

        moveDistance = Vector3.Distance(startPos, mousePos);

        if(moveDistance > limitDistance)
        {
            joy.rectTransform.position = startPos + (direction * limitDistance);
        }
        else
        {
            joy.rectTransform.position = mousePos;
        }
    }

    public void EndDrageEvent()
    {
        isDragging = false;
        joy.rectTransform.position = startPos;
    }
}
