using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {

	public int			_minite;
	public float		_second;

	public float _x;
	public float _y;

	Vector3 _pos;

	public Camera		_camera;

	private HingeJoint	_joint;
	private Rigidbody	_rb;
	private GameObject	_gameobject;

	private bool		_fInit;

	public float _time;
	public float _time2;

	// Use this for initialization
	void Start () {

		_second = 0;
		_joint = GetComponent<HingeJoint> ();
		_time = Random.Range(3, 10);
		_time2 = _time + 3;
	}

	// Update is called once per frame
	void Update () {
//		TouchInfo info = AppUtil.GetTouch();
//		if (info == TouchInfo.Began)
//		{
//			if( _fInit == false ) {
//				_fInit = true;
//			}
//		}

		if( Time.timeScale < 0 ) { return; }

		_second += Time.deltaTime;
		Debug.Log(">>_time = "+_time+", _time2="+_time2+", _second="+_second);
		if( _time <=_second ) {
			_minite++;
//			_second -= 60.0f;
			_joint.breakForce = 1;
//			Application.LoadLevel ("Title");
		}

//		if (_time2 <= _second) {
//			Application.LoadLevel ("Title");
//		}
//		_timeText.text = "TITLE SCENE : " + _minite.ToString ("00") + ":" + _second.ToString ("00");
	}
}
