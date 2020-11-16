 using UnityEngine;
 using System.Collections;
 
 public class CameraFollowPlayer : MonoBehaviour {
  
  public GameObject player;
  
  // Update is called once per frame
  void Update () {
  
  this.gameObject.transform.position = new Vector3(player.gameObject.transform.position.x,player.gameObject.transform.position.y,player.gameObject.transform.position.z);
  
  }
}