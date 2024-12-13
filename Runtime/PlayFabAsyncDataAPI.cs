using Cysharp.Threading.Tasks;
using PlayFab;
using PlayFab.DataModels;

namespace PlayFabAsyncSDKUniTask.Runtime
{
	public class PlayFabAsyncDataAPI
	{
		public static UniTask<PlayFabAsyncResult<AbortFileUploadsResponse>> AbortFileUploadsAsync(AbortFileUploadsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<AbortFileUploadsResponse>> tcs = new();

			PlayFabDataAPI.AbortFileUploads
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<AbortFileUploadsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<AbortFileUploadsResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<DeleteFilesResponse>> DeleteFilesAsync(DeleteFilesRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<DeleteFilesResponse>> tcs = new();

			PlayFabDataAPI.DeleteFiles
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<DeleteFilesResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<DeleteFilesResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<FinalizeFileUploadsResponse>> FinalizeFileUploadsAsync(FinalizeFileUploadsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<FinalizeFileUploadsResponse>> tcs = new();

			PlayFabDataAPI.FinalizeFileUploads
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<FinalizeFileUploadsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<FinalizeFileUploadsResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetFilesResponse>> GetFilesAsync(GetFilesRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetFilesResponse>> tcs = new();

			PlayFabDataAPI.GetFiles
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetFilesResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetFilesResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetObjectsResponse>> GetObjectsAsync(GetObjectsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetObjectsResponse>> tcs = new();

			PlayFabDataAPI.GetObjects
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetObjectsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetObjectsResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<InitiateFileUploadsResponse>> InitiateFileUploadsAsync(InitiateFileUploadsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<InitiateFileUploadsResponse>> tcs = new();

			PlayFabDataAPI.InitiateFileUploads
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<InitiateFileUploadsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<InitiateFileUploadsResponse>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<SetObjectsResponse>> SetObjectsAsync(SetObjectsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<SetObjectsResponse>> tcs = new();

			PlayFabDataAPI.SetObjects
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<SetObjectsResponse>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<SetObjectsResponse>(null, error)); }
			);

			return tcs.Task;
		}
	}
}
