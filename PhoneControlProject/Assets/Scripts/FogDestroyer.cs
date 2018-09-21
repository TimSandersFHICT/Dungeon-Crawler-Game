using UnityEngine;

public class FogDestroyer : MonoBehaviour {

    public LayerMask fogLayer;

    void Update()
    {
        Ray ray = new Ray(transform.position, (Player.Instance.GetPlayerTransform().position - transform.position));
        RaycastHit hit;

        //Remove in case of removing the effect once player has been at a certain location
        //for (int i = 0; i < colors.Length; i++)
        //{
        //    colors[i] = Color.black;
        //}

        if (Physics.Raycast(ray, out hit, 2000, fogLayer, QueryTriggerInteraction.Collide))
        {
            GameObject temp = hit.transform.gameObject;
            temp.GetComponent<FogOfWar>().Hit(hit);
        }
    }
}