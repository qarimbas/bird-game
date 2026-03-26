using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(Consts.WheatTypes.GOLD_WHEAT))
        {
            Debug.Log("Player collected GOLD wheat!");
        }

        if (other.CompareTag(Consts.WheatTypes.HOLY_WHEAT))
        {
            Debug.Log("Player collected HOLY wheat!");
        }

        if (other.CompareTag(Consts.WheatTypes.ROTTEN_WHEAT))
        {
            Debug.Log("Player collected ROTTEN wheat!");
        }
    }
}
