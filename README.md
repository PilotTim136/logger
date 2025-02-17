# logger
Logger like unity has.


## Features
- Basic logging with colors (Log, Warning, Error)  
- Optional "Fancy" logger with more details  
- Console allocation for non-console applications  
- Clear console and read user input  

## Installation
Just include `debug.dll` as project reference in your C# project.

## Example
Import by doing
```cs
using logger;
using logger.fancy;
```
> **notice**: logger.fancy is not needed. It's just for fancier logging.
## Usage
You can use `logger` like that:
```cs
using logger;
Debug.Log("log-message"); //message - white
Debug.LogWarning("log-warning"); //warning - yellow
Debug.LogError("log-error"); //error - red
```
Or you can use `fancylogger` like this:
```cs
using logger.fancy;
Debugf.Log("fancy-log-message"); //message - green
Debugf.LogWarning("fancy-log-warning"); //warning - yellow
Debugf.LogError("fancy-log-error"); //error - red
```
> **Notice**: Using `logger.fancy` adds more details to the logging.

If you have C# Projects that don't open a console, you can use
```cs
Debug.AllocConsole();
```
If you want to clear the console, you can do
```cs
Debug.LogClear();
```
You can also get an Input from the user
```cs
string input = Debug.LogInput();
```
> **notice**: `logger` and `logger.fancy` both have the same functions sometimes. like `AllocConsole()`, `LogClear()` and `LogInput()`.
