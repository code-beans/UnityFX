# DocFx Unity Template Sandbox Project

Checkout the [sandbox branch](https://github.com/code-beans/UnityFX/tree/sandbox) in the template repository


## Features

### Alerts


```
>[!NOTE]
> some info
```

renders

>[!NOTE]
> some info


```
>[!TIP]
> useful tips
```

renders

>[!TIP]
> useful tips

```
>[!CAUTION]
> This is not threadsafe
```

renders

>[!CAUTION]
> This is not threadsafe

### Code Highlighting
```
    ```csharp
    public void Update() {
        foo();
    }

    ```
```

renders


```csharp
public void Update() {
    foo();
}

```


for more take a look at the [official DocFX documentation](https://dotnet.github.io/docfx/tutorial/docfx_getting_started.html)