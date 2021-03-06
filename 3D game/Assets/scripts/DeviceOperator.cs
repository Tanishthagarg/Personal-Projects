using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeviceOperator : MonoBehaviour
{
    [SerializeField] private float _radius = 1.5f;
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.D)&&GameManager.SharedInstance.GMLevel==1)||(Input.GetKeyDown(KeyCode.C)))//&&GameManager.SharedInstance.GMLevel==2))
        {
            Collider[] hitColliders =
            Physics.OverlapSphere(transform.position, _radius);
            foreach (Collider hitCollider in hitColliders)
            {
                Vector3 hitPosition = hitCollider.transform.position;
                hitPosition.y = transform.position.y;
                Vector3 direction = hitPosition - transform.position;
                if (Vector3.Dot(transform.forward, direction.normalized) > .5f)
                {
                    hitCollider.SendMessage("Operate",
                    SendMessageOptions.DontRequireReceiver);
                }
            }
        }
    }
}
