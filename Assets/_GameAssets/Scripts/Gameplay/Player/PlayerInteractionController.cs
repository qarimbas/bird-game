using UnityEngine;

public class PlayerInteractionController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(Consts.WheatTypes.GOLD_WHEAT))
        {
            //Debug.Log("Player collected GOLD wheat!");
            other.gameObject?.GetComponent<GoldWheatCollectible>().Collect();
        }

        if (other.CompareTag(Consts.WheatTypes.HOLY_WHEAT))
        {
            //Debug.Log("Player collected HOLY wheat!");
            other.gameObject?.GetComponent<HolyWheatCollectible>().Collect();
        }

        if (other.CompareTag(Consts.WheatTypes.ROTTEN_WHEAT))
        {
            //Debug.Log("Player collected ROTTEN wheat!");
            other.gameObject?.GetComponent<RottenWheatCollectible>().Collect();
        }
    }
}
