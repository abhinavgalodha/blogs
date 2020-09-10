## Problem Statement
How to do the Multi-line Search and replace?

## Scenarios

Need to replace code like

### Before
```
#pragma warning disable CA1062
catch(Exception ex)
#pragma warning restore CA1062
```

### After
```
catch(Exception ex)
```

## Solution
1. Use Visual Studio Extension

VS Extension at https://marketplace.visualstudio.com/items?itemName=PeterMacej.MultilineSearchandReplace&ssr=false#review-details

This extension allows multiline search and replace in Visual Studio. This is a user-friendly GUI wrapper over standard VS "Find" and "Find in Files" dialog. You don't have to use the regex syntax, the extension takes care of it. It also allows to save your searches.

2. Use Regular Expression



