# DevelopmentTemplate

長期開発用テンプレート
制作中

# 命名規則

## C#

- 名前空間名は[パスカルケース](https://wa3.i-3-i.info/word13955.html) (先頭大文字)

- クラス名は[パスカルケース](https://wa3.i-3-i.info/word13955.html) (先頭大文字)

- プロパティ名は[パスカルケース](https://wa3.i-3-i.info/word13955.html) (先頭大文字)

- 変数名は[ローワーキャメルケース](https://e-words.jp/w/%E3%82%AD%E3%83%A3%E3%83%A1%E3%83%AB%E3%82%B1%E3%83%BC%E3%82%B9.html) (先頭小文字)

- メンバー変数の接頭辞には「＿」(アンダースコア)を付けてください

- bool型変数の接頭辞には「is」を付けてください

- UI型変数の接尾辞には基本的にUI名を付けてください

- 定数名は[アッパースネークケース](https://e-words.jp/w/%E3%82%B9%E3%83%8D%E3%83%BC%E3%82%AF%E3%82%B1%E3%83%BC%E3%82%B9.html#:~:text=%E3%82%B9%E3%83%8D%E3%83%BC%E3%82%AF%E3%82%B1%E3%83%BC%E3%82%B9%E3%81%A8%E3%81%AF%E3%80%81%E3%83%97%E3%83%AD%E3%82%B0%E3%83%A9%E3%83%9F%E3%83%B3%E3%82%B0,%E3%81%AA%E8%A1%A8%E8%A8%98%E3%81%8C%E3%81%93%E3%82%8C%E3%81%AB%E5%BD%93%E3%81%9F%E3%82%8B%E3%80%82)

- イベント名は[パスカルケース](https://wa3.i-3-i.info/word13955.html) (先頭大文字)

- イベントの接頭辞には「On」を付けてください

- 関数名は[パスカルケース](https://wa3.i-3-i.info/word13955.html) (先頭大文字)

|  | 命名方法 | 例 |
| - | - | - |
| 名前空間 | [パスカルケース](https://wa3.i-3-i.info/word13955.html) | NameSpace |
| クラス | [パスカルケース](https://wa3.i-3-i.info/word13955.html) | ClassName |
| プロパティ | [パスカルケース](https://wa3.i-3-i.info/word13955.html) | PropertyName |
| 変数 | [ローワーキャメルケース](https://e-words.jp/w/%E3%82%AD%E3%83%A3%E3%83%A1%E3%83%AB%E3%82%B1%E3%83%BC%E3%82%B9.html) | memberName |
| メンバー変数 | 「_」 + 変数名 | _●● |
| bool型変数 | 「is」 + 変数名 | is●● |
| UI型変数 | 変数名 + UI名 | ●●Text |
| 定数 | [アッパースネークケース](https://e-words.jp/w/%E3%82%B9%E3%83%8D%E3%83%BC%E3%82%AF%E3%82%B1%E3%83%BC%E3%82%B9.html#:~:text=%E3%82%B9%E3%83%8D%E3%83%BC%E3%82%AF%E3%82%B1%E3%83%BC%E3%82%B9%E3%81%A8%E3%81%AF%E3%80%81%E3%83%97%E3%83%AD%E3%82%B0%E3%83%A9%E3%83%9F%E3%83%B3%E3%82%B0,%E3%81%AA%E8%A1%A8%E8%A8%98%E3%81%8C%E3%81%93%E3%82%8C%E3%81%AB%E5%BD%93%E3%81%9F%E3%82%8B%E3%80%82) | MEMBER_NAME |
| イベント | [パスカルケース](https://wa3.i-3-i.info/word13955.html) & 「On」 + イベント名 | On●● |
| 関数 | [パスカルケース](https://wa3.i-3-i.info/word13955.html) | MethodName |


## Unity

- アセットやファイル、オブジェクトなどは全てパスカルケース

- UIオブジェクトの接頭辞にはUI名を付けてください

|  | 命名方法 | 例 |
| - | - | - |
| アセット | [パスカルケース](https://wa3.i-3-i.info/word13955.html) | AssetName |
| ファイル | [パスカルケース](https://wa3.i-3-i.info/word13955.html) | FileName |
| オブジェクト | [パスカルケース](https://wa3.i-3-i.info/word13955.html) | ObjectName |
| UIオブジェクト | オブジェクト名 + UI名 | ●●Text |

## Sourcetree

- ブランチの名前は[スネークケース](https://e-words.jp/w/%E3%82%B9%E3%83%8D%E3%83%BC%E3%82%AF%E3%82%B1%E3%83%BC%E3%82%B9.html#:~:text=%E3%82%B9%E3%83%8D%E3%83%BC%E3%82%AF%E3%82%B1%E3%83%BC%E3%82%B9%E3%81%A8%E3%81%AF%E3%80%81%E3%83%97%E3%83%AD%E3%82%B0%E3%83%A9%E3%83%9F%E3%83%B3%E3%82%B0,%E3%81%AA%E8%A1%A8%E8%A8%98%E3%81%8C%E3%81%93%E3%82%8C%E3%81%AB%E5%BD%93%E3%81%9F%E3%82%8B%E3%80%82)
(単語と単語の間には「＿」(アンダースコア))

- 機能を作成するブランチであれば接頭辞に「feature/」を付けてください

- 機能の修正等は接頭辞に「hotfix/」を付けてください

- 削除を行う際は接頭辞に「remove/」を付けてください

|  | 命名方法 | 例 |
| - | - | - |
| ブランチ | スネークケース | branch_name |
| 機能作成 | 「feature/」 + ブランチ名 | feature/branch_name |
| 機能修正 | 「hotfix/」 + ブランチ名 | hotfix/branch_name |
| 機能削除 | 「remove/」 + ブランチ名 | remove/branch_name |
