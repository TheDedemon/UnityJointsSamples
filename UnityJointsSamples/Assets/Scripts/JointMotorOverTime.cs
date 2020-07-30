using UnityEngine;

namespace MuchoBestoStudio.JointsSystemSamples
{
	public class JointMotorOverTime : MonoBehaviour
	{
		#region Variables

		[SerializeField]
		private HingeJoint _hingeJoint = null;
		[SerializeField]
		private AnimationCurve _targetVelocityOverTime = null;
		[SerializeField]
		private AnimationCurve _forceOverTime = null;

		private float _time = 0f;
		private JointMotor _jointMotor;

		#endregion

		#region Awake

		private void Awake()
		{
			_jointMotor = _hingeJoint.motor;
		}

		#endregion

		#region Update

		private void Update()
		{
			_time += Time.deltaTime;

			_jointMotor.targetVelocity = _targetVelocityOverTime.Evaluate(_time);
			_jointMotor.force = _forceOverTime.Evaluate(_time);

			_hingeJoint.motor = _jointMotor;
		}


		#endregion
	}
}
