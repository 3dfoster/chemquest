private var startTime : float;
var pollTime : float = 3.0;
var spaceToSpread : Vector3 = new Vector3(5,0,5);

function Start()
{
	startTime = Time.time;
}


function Update()
{
	if(Time.time > (startTime + pollTime))
	{
			startTime = Time.time;
			CloneFire();
	}
	if (Time.time >= 30)
		Application.LoadLevel("gameOver");
}

function CloneFire()
{
	if ((startTime + pollTime) < 25)
	{
		var newFirePos : Vector3 = transform.position + Vector3(Random.Range(- spaceToSpread.x, spaceToSpread.x), Random.Range( -spaceToSpread.y, spaceToSpread.y), Random.Range(- spaceToSpread.z, spaceToSpread.z));
		var newFire = GameObject.Instantiate(gameObject, newFirePos, Quaternion.identity);
	}
}