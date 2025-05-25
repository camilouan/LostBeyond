using Unity.VisualScripting;
using UnityEngine;

public class Follow : MonoBehaviour
{
	public GameObject target;

	private float target_poseX;
	private float target_posey;

	private float posX;
	private float posY;

	public float derechaMax;
	public float izquierdaMax;
	public float alturaMax;
	public float alturaMin;

	public float speed;
	public bool encendida = true;

	void Awake()
	{
		posX = target_poseX + derechaMax;
		posY = target_posey + alturaMin;

		transform.position = Vector3.Lerp(transform.position, new Vector3(posX, posY, -100), 1);
	}

	private void Update()
{
		Move_Cam();
}
	void Move_Cam()
	{
		if (encendida)
		{
			if (target)
			{
				target_poseX = target.transform.position.x;
				target_posey = target.transform.position.y;

				if (target_poseX > derechaMax && target_poseX < izquierdaMax)
				{
					posX = target_poseX;
				}

				if (target_posey < alturaMax && target_posey > alturaMin)
				{
					posY = target_posey;
				}
			}

			transform.position = Vector3.Lerp(transform.position, new Vector3(posX, posY, -100), speed*Time.deltaTime);
		}
	}
}

