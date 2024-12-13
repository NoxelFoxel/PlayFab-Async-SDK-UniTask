using Cysharp.Threading.Tasks;
using PlayFab;
using PlayFab.CloudScriptModels;

namespace PlayFabAsyncSDKUniTask.Runtime
{
	public class PlayFabAsyncCloudScriptAPI
	{
		public static UniTask<PlayFabAsyncResult<ExecuteCloudScriptResult>> ExecuteEntityCloudScriptAsync(
			ExecuteEntityCloudScriptRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ExecuteCloudScriptResult>> tcs = new();

			PlayFabCloudScriptAPI.ExecuteEntityCloudScript
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ExecuteCloudScriptResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ExecuteCloudScriptResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ExecuteFunctionResult>> ExecuteFunctionAsync(ExecuteFunctionRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ExecuteFunctionResult>> tcs = new();

			PlayFabCloudScriptAPI.ExecuteFunction
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ExecuteFunctionResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ExecuteFunctionResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<GetFunctionResult>> GetFunctionAsync(GetFunctionRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<GetFunctionResult>> tcs = new();

			PlayFabCloudScriptAPI.GetFunction
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<GetFunctionResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<GetFunctionResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ListFunctionsResult>> ListFunctionsAsync(ListFunctionsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ListFunctionsResult>> tcs = new();

			PlayFabCloudScriptAPI.ListFunctions
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ListFunctionsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ListFunctionsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ListHttpFunctionsResult>> ListHttpFunctionsAsync(ListFunctionsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ListHttpFunctionsResult>> tcs = new();

			PlayFabCloudScriptAPI.ListHttpFunctions
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ListHttpFunctionsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ListHttpFunctionsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<ListQueuedFunctionsResult>> ListQueuedFunctionsAsync(ListFunctionsRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<ListQueuedFunctionsResult>> tcs = new();

			PlayFabCloudScriptAPI.ListQueuedFunctions
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<ListQueuedFunctionsResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<ListQueuedFunctionsResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResult>> PostFunctionResultForEntityTriggeredActionAsync(
			PostFunctionResultForEntityTriggeredActionRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResult>> tcs = new();

			PlayFabCloudScriptAPI.PostFunctionResultForEntityTriggeredAction
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResult>> PostFunctionResultForFunctionExecutionAsync(
			PostFunctionResultForFunctionExecutionRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResult>> tcs = new();

			PlayFabCloudScriptAPI.PostFunctionResultForFunctionExecution
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResult>> PostFunctionResultForPlayerTriggeredActionAsync(
			PostFunctionResultForPlayerTriggeredActionRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResult>> tcs = new();

			PlayFabCloudScriptAPI.PostFunctionResultForPlayerTriggeredAction
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResult>> PostFunctionResultForScheduledTaskAsync(
			PostFunctionResultForScheduledTaskRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResult>> tcs = new();

			PlayFabCloudScriptAPI.PostFunctionResultForScheduledTask
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResult>> RegisterHttpFunctionAsync(RegisterHttpFunctionRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResult>> tcs = new();

			PlayFabCloudScriptAPI.RegisterHttpFunction
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResult>> RegisterQueuedFunctionAsync(RegisterQueuedFunctionRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResult>> tcs = new();

			PlayFabCloudScriptAPI.RegisterQueuedFunction
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(null, error)); }
			);

			return tcs.Task;
		}

		public static UniTask<PlayFabAsyncResult<EmptyResult>> UnregisterFunctionAsync(UnregisterFunctionRequest request)
		{
			UniTaskCompletionSource<PlayFabAsyncResult<EmptyResult>> tcs = new();

			PlayFabCloudScriptAPI.UnregisterFunction
			(
				request, result => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(result, null)); },
				error => { tcs.TrySetResult(new PlayFabAsyncResult<EmptyResult>(null, error)); }
			);

			return tcs.Task;
		}
	}
}
