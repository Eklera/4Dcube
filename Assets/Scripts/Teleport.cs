using UnityEngine;

public class Teleport : MonoBehaviour {

	public bool teleported = false;
	public Teleport target;
	
	void OnTriggerEnter (Collider other)
	{
		if (other.CompareTag("MainCamera"))
		{
			if (!teleported)
			{
				target.teleported = true;
				other.transform.position = target.gameObject.transform.position;
			}
		}
	}
	
	void OnTriggerExit (Collider other)
	{
		if(other.CompareTag("MainCamera"))
		{
			teleported = false;
		}
	}
}
