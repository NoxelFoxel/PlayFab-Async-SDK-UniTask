# PlayFab Async SDK

PlayFab Async SDK is a lightweight, asynchronous wrapper for PlayFab APIs built using UniTask. It simplifies the process of integrating
PlayFab into your Unity projects, allowing you to write clean and maintainable asynchronous code.

## Features

- Fully asynchronous API calls with UniTask.
- Simplifies PlayFab integration in Unity.
- Supports PlayFab's Client, CloudScript, Data, Economy, and Profiles APIs.

## Installation

### Option 1: Install via Unity Package Manager (Git URL)

You can install the package directly from the GitHub repository:

1. Open Unity and navigate to `Window > Package Manager`.
2. Click the `+` button in the top left corner.
3. Select `Add package from git URL...`.
4. Enter the following URL:

   ```
   https://github.com/NoxelFoxel/PlayFab-Async-SDK-UniTask.git
   ```

5. Click `Add`.

### Option 2: Modify `manifest.json`

You can also install the package by editing the `manifest.json` file in your Unity project:

1. Add the following entry to the `dependencies` section:

   ```json
   "dependencies": {
       "com.noxelfoxel.playfab-async-sdk": "https://github.com/NoxelFoxel/PlayFab-Async-SDK-UniTask.git"
   }
   ```

2. Save the file, and Unity will automatically download and import the package.

### Option 3: Manual Installation

1. Clone or download the repository from GitHub.
2. Copy the folder into your Unity project's `Packages/` directory.

## Usage

### Example: Logging in a User

```csharp
using PlayFab;
using PlayFab.ClientModels;
using System;
using Cysharp.Threading.Tasks;
using UnityEngine;

public class AsyncLoginExample
{
    public async UniTask LoginWithCustomIDAsync(string customId)
    {
        LoginWithCustomIDRequest request = new() { CustomId = customId, CreateAccount = true };

        try
        {
            PlayFabAsyncResult<LoginResult> response = await PlayFabClientAPIAsync.LoginWithCustomIDAsync(request);
            Debug.Log($"Login successful! PlayFab ID: {response.PlayFabId}");
        }
        catch (PlayFabException e)
        {
            Debug.LogError($"Login failed: {e.ErrorMessage}");
        }
    }
}
```

## Requirements

- Unity 2020.3 or later.
- [UniTask](https://github.com/Cysharp/UniTask).
- [PlayFab SDK](https://github.com/PlayFab/UnitySDK).

## Contributing

We welcome contributions! Please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or fix.
3. Commit your changes and open a pull request.

## Support

If you encounter issues or have questions, feel free to open an issue on
the [GitHub repository](https://github.com/NoxelFoxel/PlayFab-Async-SDK-UniTask).
