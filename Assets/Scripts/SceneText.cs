using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class SceneText : MonoBehaviour {

	private int		_minite;
	private float	_second;
//	public Text		_timeText;

	private bool _fInit;

	// Use this for initialization
	void Start () {
		_minite = 0;
		_second = 0;
//		_timeText = GetComponent<Text>();
		_fInit = false;
	}
	
	// Update is called once per frame
	void Update () {
		TouchInfo info = AppUtil.GetTouch();
		if (info == TouchInfo.Began)
		{
			if( _fInit == false ) {
				Application.LoadLevel ("Main");
				_fInit = true;
			}
		}

//		if( !_fInit ) { return; }
//		if( Time.timeScale < 0 ) { return; }
//
//		_second += Time.deltaTime;
//		if( 5.0f <=_second ) {
//			_minite++;
//			_second -= 60.0f;
//			Application.LoadLevel ("Main");
//		}
//		_timeText.text = "TITLE SCENE : " + _minite.ToString ("00") + ":" + _second.ToString ("00");
	}
}
