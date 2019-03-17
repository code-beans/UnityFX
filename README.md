# UnityFX

DocFX Template to create Unity-esque code documentation. [Demo](https://code-beans.github.io/UnityFX/articles/intro.html)

## Changes from Default Template

- Full Width
- Custom _TIP_ alert 
- Different colors
- Custom Breadcrumb
- Custom Sidebar

## How to use

0. install docfx

1. The template is contained in the _templates_ folder. Drop the entire folder into your root-level docfx project folder, next to your _api/_ and _articles/_ folders.

2. In your docfx.json (showing only relevant portion):

```json
{
    "build": {
        "template": [ "default", "templates/unity" ],
    }
}
```

3. compile as you would using the default template

## Contribute

You are more than welcome to contribute. No code of conduct required, just be reasonable.

**Open TODOs:**

* Search in navbar
* table for `public` properties and fields

## Disclaimer

Notice of Non-Affiliation and Disclaimer 

We are not affiliated, associated, authorized, endorsed by, or in any way officially connected with Unity Technologies, or any of its subsidiaries, partners or its affiliates. The official Unity Technologies website can be found at https://unity.com/. "Unity", Unity logos, and other Unity trademarks are trademarks or registered trademarks of Unity Technologies or its affiliates in the U.S. and elsewhere.

