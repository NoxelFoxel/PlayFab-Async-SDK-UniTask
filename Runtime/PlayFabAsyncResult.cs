using PlayFab;

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

			if (IsError)
			{
				UnityEngine.Debug.LogError($"{e.Error}: {e.ErrorMessage}");

				if (e.ErrorDetails != null)
				{
					foreach (var kv in e.ErrorDetails)
					{
						foreach (var v in kv.Value)
						{
							UnityEngine.Debug.LogError(v);
						}
					}
				}
			}
		}
	}
}
