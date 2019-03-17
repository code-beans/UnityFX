---
uid: Assets.Src.ShootScript.FireRate
example: [*content]
---

```
void OnCollisionEnter(Collider other) {
    //half fire rate when hit.
    gameObject.GetComponent<ShootScript>().FireRate /= 2;
}
```