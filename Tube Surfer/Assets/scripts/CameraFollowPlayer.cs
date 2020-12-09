 using UnityEngine;
 using System.Collections;
 
 public class CameraFollowPlayer : MonoBehaviour {
  
  public GameObject player;

 
  public Vector3 target_Offset;
  private void Start()
  {
      target_Offset = transform.position - player.transform.position;
  }
  void Update()
  {
      if (player.transform)
      {
          transform.position = Vector3.Lerp(transform.position, player.transform.position + target_Offset, 0.1f);
      }
  }
}