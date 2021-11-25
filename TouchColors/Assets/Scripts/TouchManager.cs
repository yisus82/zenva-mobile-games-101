using UnityEngine;

public class TouchManager : MonoBehaviour
{
  void Update()
  {
    if (Input.touchCount > 0)
    {
      Touch touch = Input.GetTouch(0);
      if (touch.phase == TouchPhase.Began)
      {
        Ray ray = Camera.main.ScreenPointToRay(touch.position);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
          if (hit.collider != null)
          {
            Color color = new Color(Random.value, Random.value, Random.value);
            hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = color;
          }
        }
      }
    }
  }
}
