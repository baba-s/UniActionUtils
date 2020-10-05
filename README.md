# UniActionUtils

Action 型に関係する汎用的な関数を管理するクラス

## 使用例

```cs
using Kogane;
using System;
using UnityEngine;

public class Example : MonoBehaviour
{
    public Action onClick;

    private void Awake()
    {
        // onClick 実行後に onClick は null になる
        ActionUtils.CallOnce( ref onClick );
    }
}
```
