using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class UIElementsXR : MonoBehaviour
{
    public UnityEvent onXRPointerEnter;
    public UnityEvent onXRPointerExit;
    private Camera xRCamera;
    void Start()
    {
        xRCamera = CameraPointerManager.instance.gameObject.GetComponent<Camera>();
    }

    public void OnPointerClickXR()
    {
        PointerEventData pointerEvent = PlacePointer();
        ExecuteEvents.Execute(this.gameObject, pointerEvent, ExecuteEvents.pointerClickHandler);
    }

    public void OnPointerEnterXR()
    {
        GazeManager.Instance.SetUpGaze(1.5f);
        onXRPointerEnter?.Invoke();
        PointerEventData pointerEvent = PlacePointer();
        ExecuteEvents.Execute(this.gameObject, pointerEvent, ExecuteEvents.pointerDownHandler);
    }

    public void OnPointerExitXR()
    {
        GazeManager.Instance.SetUpGaze(2.5f);
        onXRPointerExit?.Invoke();
        PointerEventData pointerEvent = PlacePointer();
        ExecuteEvents.Execute(this.gameObject, pointerEvent, ExecuteEvents.pointerUpHandler);
    }

    private PointerEventData PlacePointer()
    {
        Vector3 screePos = xRCamera.WorldToScreenPoint(CameraPointerManager.instance.hitPoint);
        var pointer = new PointerEventData(EventSystem.current);
        pointer.position = new Vector2(screePos.x, screePos.y);
        return pointer;
    }
}
