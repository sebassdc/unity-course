using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
  public GameObject bulletPrefab;
  public GameObject shooter;
  private Transform _firepoint;

  void Awake()
  {
    _firepoint = transform.Find("FirePoint");
  }

  void Start()
  {
    // Invoke("Shoot", 1f);
    // Invoke("Shoot", 2f);
    // Invoke("Shoot", 3f);
  }

  void Update()
  {

  }

  public void Shoot()
  {
    if (bulletPrefab != null && _firepoint != null && shooter != null)
    {
      GameObject myBullet = Instantiate(bulletPrefab, _firepoint.position, Quaternion.identity) as GameObject;

      Bullet bulletComponent = myBullet.GetComponent<Bullet>();

      // Vector2.left; ->> new Vector2(-1f, 0f);
      // Vector2.right; // new Vector2(1f, 0f)
      bulletComponent.direction = shooter.transform.localScale.x < 0f ? Vector2.left : Vector2.right;

    }
  }
}
