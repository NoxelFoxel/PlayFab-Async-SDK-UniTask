using PlayFab;
using UnityEngine;

namespace PlayFabAsyncSDKUniTask.Runtime
{
	public sealed class PlayFabAsyncResult<T>
	{
		public bool IsError => Error is not null;
		public T Result;
		public readonly PlayFabError Error;


		public PlayFabAsyncResult(T r, PlayFabError e)
		{
			Result = r;
			Error = e;

			if (IsError is false)
			{
				return;
			}

			Debug.LogError($"{e.Error}: {e.ErrorMessage}");

			if (e.ErrorDetails is null)
			{
				return;
			}

			foreach (var kv in e.ErrorDetails)
			{
				foreach (var v in kv.Value)
				{
					Debug.LogError(v);
				}
			}
		}
	}
}
