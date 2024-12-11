# EarTrumpetFxSoundFix

## Overview
A lightweight automated solution for the ongoing compatibility issue between EarTrumpet and FxSound ([EarTrumpet #977](https://github.com/File-New-Project/EarTrumpet/issues/977), [FxSound #753](https://forum.fxsound.com/t/fxsound-incompatible-with-eartrumpet/753)).

## Problem
EarTrumpet needs to be restarted after FxSound launches to function properly. This has been a persistent issue affecting users of both applications.

## Solution
This utility:
1. Monitors FxSound's startup process
2. Automatically launches EarTrumpet once FxSound is fully initialized

## Technical Notes
- Uses Windows App shortcut method due to UWP app sandboxing restrictions
- Zero configuration required
- Minimal system resource usage

## Installation
1. Download the latest release
2. Move your shortcut into the shortcuts folder
3. Run the executable
4. (Optional) Add to startup programs for automatic operation

## Related Issues
- [EarTrumpet Issue #977](https://github.com/File-New-Project/EarTrumpet/issues/977)
- [FxSound Forum Topic #753](https://forum.fxsound.com/t/fxsound-incompatible-with-eartrumpet/753)

## Current Issues
- Audio applications vanish from volume controls after extended usage

## Contributing
We welcome contributions to enhance this software! To contribute:

1. Fork the repository.
2. Create a new branch for your feature or bugfix (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

Make sure the program compiles correctly and runs correctly!
