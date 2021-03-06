# TDDの戦略
- 仮実装: コードにべた書きの値を使って、実装を進めながら変数に置き換える
- 明白な実装: 頭の中に思いつく、明確にテストが通る実装をコードに落とす
- 三角測量: リファクタリングの方法がわからない時に2つの実例を用意して、一般化を行う

## TDDのサイクルのフェーズ
1. テストを書く
2. コンパイラを通す
3. テストを走らせて、失敗を確認する
4. テストを通す
5. 重複を排除する

この流れで3までは速く通過したい  
よって以下のように原則を破るときもある

### 大きいテストは難しいなと思ったとき
1. とりあえず小さなテストを作成する。  
2. 重複してもいいので既存のテストやモデルをコピペしてテストを通してみる  
3. 重複を消す

# C#についての注意
## Asserts.AreEqualについて
同じ型の値を比較できるが、同じクラス同士の比較はダメ
```
// これはOK
// fiveはDollar(5)でTimes(x)メソッドはamountsをx倍にするもの
int product = five.Times(2)
Assert.AreEqual(10, product.amounts)
// これはできない
Assert.AreEqual(new Dollar(10), five.Times(2))
```
Equalメソッドをオーバーライドして`Assert.IsTrue`で見てやる必要がある

## 継承とアクセスレベル
継承する際にアクセスレベルを考慮する必要がある
詳細は[継承](https://docs.microsoft.com/ja-jp/dotnet/csharp/fundamentals/object-oriented/inheritance)と[アクセシビリティ レベル](https://docs.microsoft.com/ja-jp/dotnet/csharp/language-reference/keywords/accessibility-levels)を参照
