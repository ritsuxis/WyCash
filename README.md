# TDDの戦略
- 仮実装: コードにべた書きの値を使って、実装を進めながら変数に置き換える
- 明白な実装: 頭の中に思いつく、明確にテストが通る実装をコードに落とす
- 三角測量: リファクタリングの方法がわからない時に2つの実例を用意して、一般化を行う

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
