using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thTask2
{
    public class Messages
    {
        public static string MasterName { get; } = "マサヒ";

        /// <summary>
        /// ロード時
        /// </summary>
        public static string Load { get; } = $@"初めまして！
僕の名前は{MasterName}！
君の名前を教えてね！
";

        /// <summary>
        /// 名前入力
        /// </summary>
        public static string StepName { get; } = @"だね！
よろしくね！
次に年齢を教えてね！
";

        /// <summary>
        /// 名前入力エラー
        /// </summary>
        public static string StepNameError { get; } = @"君の名前を教えてね！
";

        /// <summary>
        /// 年齢入力
        /// </summary>
        public static string StepAge { get; } = @"歳なのかあ...
年齢なんて関係ないよ！
好きなアクションを選んでね！
";

        /// <summary>
        /// 年齢入力エラー
        /// </summary>
        public static string StepAgeError { get; } = @"数値を入力してね！
";

        /// <summary>
        /// Hi
        /// </summary>
        public static string Hi { get; } = @"やあ
";

        /// <summary>
        /// 座る
        /// </summary>
        public static string Sit { get; } = @"・・・
";

        /// <summary>
        /// 歩く
        /// </summary>
        public static string Walk { get; } = @"ﾃｸﾃｸ
";

        /// <summary>
        /// 進行文1
        /// </summary>
        public static string Progress1 { get; } = $@"久しぶり！{MasterName}だよ！
みんな覚えてる？？
ここからはC#の基礎、クラスとメソッドとかの説明をするよ！
準備はいいかな？
";

        /// <summary>
        /// 進行文2
        /// </summary>
        public static string Progress2 { get; } = $@"なんとなくオブジェクト指向について理解できたかな？
ここからは各パーツ、用語単位での説明を進めていくよ！
準備はいいかな？
まずはコンストラクターだよ！
";

        /// <summary>
        /// クラス1
        /// </summary>
        public static string Class1 { get; } = $@"まずはクラスの説明だよ！
クラスはオブジェクト指向で出てくる概念のひとつで「それが、どんなものか」を表した設計図のことだよ！
オブジェクト指向は「『モノ』に注目した考え方」で「どんな奴で、どう動く」に注目した考え方だよ。
";

        /// <summary>
        /// クラス1
        /// </summary>
        public static string Class2 { get; } = $@"例えば、ピヨ太君がオリジナルのピヨピヨ時計を作ることにしました。
";

        /// <summary>
        /// クラス1
        /// </summary>
        public static string Class3 { get; } = $@"まずは、どんな時計にするか考えます。
ピヨ太君は頭の中でピヨピヨ時計の設計図を作りました。
";

        /// <summary>
        /// クラス1
        /// </summary>
        public static string Class4 { get; } = $@"次に、頭の中の設計図をもとにして実際のピヨピヨ時計を作りました。
";

        /// <summary>
        /// クラス1
        /// </summary>
        public static string Class5 { get; } = $@"この話における「設計図」が「クラス」です。
「ピヨピヨ時計」が「インスタンス」に相当します。
「設計図」と「ピヨピヨ時計」（と「ピヨ太君」もかな？）が「オブジェクト」です。
";

        /// <summary>
        /// クラス1
        /// </summary>
        public static string Class6 { get; } = $@"クラスの説明は以上だよ。
みんな理解できたかな？次はメソッドの説明に入るよ！
もう一度説明を聞きたい場合は上から選択してね！
";

        /// <summary>
        /// メソッド1
        /// </summary>
        public static string Method1 { get; } = $@"ここからはメソッドの説明だよ！
メソッドはオブジェクト指向で出てくる操作（動作）のひとつでオブジェクトの操作を定義したものだよ～。
";

        /// <summary>
        /// メソッド1
        /// </summary>
        public static string Method2 { get; } = $@"例えば、ここにピヨ太君がいたとしましょう。
";

        /// <summary>
        /// メソッド1
        /// </summary>
        public static string Method3 { get; } = $@"オブジェクト指向で考えた場合、ピヨ太君は「モノ」です。
";

        /// <summary>
        /// メソッド1
        /// </summary>
        public static string Method4 { get; } = $@"さて、このピヨ太君ですが、どんな奴だと思いますか？
まずピヨ太君の性格や嗜好は以下です。
・基本的にのんびり屋
・たまに頑張り屋さん
・寝るのが好き
・食べるのも好き
";

        /// <summary>
        /// メソッド1
        /// </summary>
        public static string Method5 { get; } = $@"ピヨ太君ができることは
・寝る
・食べる
・遊ぶ
です。
";

        /// <summary>
        /// メソッド1
        /// </summary>
        public static string Method6 { get; } = $@"これをまとめると、以下のようになります。
モノ：ピヨ太君
　■どんな奴
　　・基本的にのんびり屋、たまに頑張り屋さん、寝るのが好き、食べるのも好き
　■どう動ける
　　・寝る
　　・食べる
　　・遊ぶ
";

        /// <summary>
        /// メソッド1
        /// </summary>
        public static string Method7 { get; } = $@"これをオブジェクト指向に当てはめると、以下のようになります。
オブジェクト：ピヨ太君
　■メンバ変数
　　・基本的にのんびり屋、たまに頑張り屋さん、寝るのが好き、食べるのも好き
　■メソッド
　　・寝る
　　・食べる
　　・遊ぶ
";

        /// <summary>
        /// メソッド1
        /// </summary>
        public static string Method8 { get; } = $@"オブジェクト指向においては、何らかの「モノ」をカッコつけて言ったのが「オブジェクト」です。
「モノ」には「属性」と「操作」の2つの要素があります。
その「モノ」は「どんな奴（属性）」で「どう動けるか（操作）」を表現するためです。

この「どんな奴」で「どう動ける」のうち「どう動ける」の部分を定義したものが「メソッド」です。
以上が、メソッドの説明です。
";

        /// <summary>
        /// コンストラクター1
        /// </summary>
        public static string Constructor1 { get; } = $@"クラスの中にはコンストラクターっていうメソッドがあるよ。
クラスを生成（インスタンス化）したとき、自動的に実行される初期化用のメソッドがコンストラクターだよ。
内部からも外部からも呼び出しはできなくて、クラス初期化時にだけ実行されるよ！
";

        /// <summary>
        /// コンストラクター2
        /// </summary>
        public static string Constructor2 { get; } = $@"これがコンストラクターだよ。
見たことあるかな？実は今までの課題の中でもコンストラクターは実行されていて、
フォーム初期化時にデザインの生成とかをコンストラクターでやっていたんだよ！
";

        /// <summary>
        /// コンストラクター3
        /// </summary>
        public static string Constructor3 { get; } = $@"ちなみにコンストラクタの逆でインスタンスを破棄するときに
実行されるメソッドがデストラクタというよ！C#ではあまり使わないから一旦忘れてね！
何度か説明に出ているけど、インスタンス化ってなんだ？と思っていない？？
大丈夫！これからインスタンス化の説明をするよ！
";

        /// <summary>
        /// インスタンス化1
        /// </summary>
        public static string Instantiation1 { get; } = $@"これがクラスのインスタンス化だよ。
見たこと、やったことあるかなあ？
";

        /// <summary>
        /// インスタンス化1
        /// </summary>
        public static string Instantiation2 { get; } = $@"メソッドを使用するときは必ずクラスのインスタンスを生成するんだ！
生成したインスタンスに対して.〇〇でメソッドとかプロパティを参照できるよ！
インスタンス化は他にも「初期化」「newする」とかって呼ばれ方もするよ！
";

        /// <summary>
        /// インスタンス化1
        /// </summary>
        public static string Instantiation3 { get; } = $@"インスタンス化は何度でもできて
そのたびに中にある情報はインスタンス単位で初期化されていくんだ。
次はメソッド詳細の説明に進むよ！
";

        /// <summary>
        /// 引数1
        /// </summary>
        public static string Argument1 { get; } = $@"引数とはプログラムや関数に渡す値のことだよ！
まずは予備知識として「関数」について簡単に説明するよ。
関数は「何かを入れると何かを計算して何かを返してくれるプログラムの部品」だよ。
一般的には、入力を受けて処理を行い、その結果として出力があるよ。
";

        /// <summary>
        /// 引数1
        /// </summary>
        public static string Argument2 { get; } = $@"以上を踏まえて
関数、あるいはプログラムに渡す値が「引数（ヒキスウ）」です。
「入力」「処理」「出力」のうち「入力」に相当する値ですね。
";

        /// <summary>
        /// 引数1
        /// </summary>
        public static string Argument3 { get; } = $@"あと、ついでなので書いておくと「出力」に相当する値は「戻り値」と言います。
せっかくなので併せて覚えてあげてください。
戻り値は別途説明するので安心してください。
";

        /// <summary>
        /// 引数4
        /// </summary>
        public static string Argument4 { get; } = $@"ちょっと汚い話で恐縮ですが、人間はご飯を食べて、ウンチを出します。
";

        /// <summary>
        /// 引数5
        /// </summary>
        public static string Argument5 { get; } = $@"人間を関数、メソッドだとすれば、ご飯に相当するものが引数です。
ウンチに相当するものが戻り値になります。
";

        /// <summary>
        /// 引数6
        /// </summary>
        public static string Argument6 { get; } = $@"ウンチの話で終わってしまうのは心苦しいので、もう少し現実的な例も挙げておきます。

あるところに翻訳関数さんがいました。
翻訳関数さんは、日本語を伝えると英語に翻訳して戻してくれます。
";

        /// <summary>
        /// 引数7
        /// </summary>
        public static string Argument7 { get; } = $@"翻訳関数さんに「リンゴ」を入れると「apple」が出てきます。
";

        /// <summary>
        /// 引数8
        /// </summary>
        public static string Argument8 { get; } = $@"このときの翻訳関数さんに入っていく「リンゴ」が引数です。
";

        /// <summary>
        /// 引数9
        /// </summary>
        public static string Argument9 { get; } = $@"あと、ついでなので書いておくと、翻訳関数さんから出てくる「apple」が戻り値です。
";

        /// <summary>
        /// 引数10
        /// </summary>
        public static string Argument10 { get; } = $@"理解できたかな？？要約すると
「引数：関数とかに入れる値」だよ。

実際のメソッドでいうと<param>って書かれてるところが引数です。
（）の中に受け取りたい引数の型を定義します。
";

        /// <summary>
        /// 引数11
        /// </summary>
        public static string Argument11 { get; } = $@"引数を渡すときはこう。
この時、渡したい値と呼び出すメソッド引数の型が違うとエラーになります。
";

        /// <summary>
        /// 引数12
        /// </summary>
        public static string Argument12 { get; } = $@"引数にはオプション機能があって引数の初期値を設定することをいいます。
オプションを付与した引数は引数群の一番後ろに定義しないと怒られます。
オプションを付与した場合、メソッド呼び出し時に引数がなくても怒られず
初期値で設定している値がメソッド内で使用されます。
";

        /// <summary>
        /// 引数13
        /// </summary>
        public static string Argument13 { get; } = $@"あとは引数には値渡し参照渡しがあって、
さっき説明した引数は値渡しになるよ。
値渡しと参照渡しの違いは他で説明するから予備知識として覚えておいてね。
";

        /// <summary>
        /// 戻り値11
        /// </summary>
        public static string ReturnValue1 { get; } = $@"戻り値とはプログラムや関数から帰ってくる値のことだよ！
戻り値の基本的な話は「引数」で説明しているから下記から確認してね！

メニューバー > 基礎 > メソッド > 引数
";

        /// <summary>
        /// 戻り値2
        /// </summary>
        public static string ReturnValue2 { get; } = $@"戻り値は要約すると「関数とかから出てくる値」のことだよ！
実際のメソッドでいうとメソッド名の前に定義されているのが戻り値の型です。
詳細は<return>ってところに書かれています。
";

        /// <summary>
        /// 戻り値3
        /// </summary>
            public static string ReturnValue3 { get; } = $@"メソッドで戻り値返却を実装しているのはこの部分。
この時、返したい値とメソッド引数の型が違うとエラーになります。
";

        /// <summary>
        /// 戻り値4
        /// </summary>
        public static string ReturnValue4 { get; } = $@"戻り値を受け取る方法はこう。
この時受け取る変数の型とメソッド引数の型が違うとエラーになります。
ちなみに、メソッドの戻り値は受け取らなくてもエラーにはなりません。
";

        /// <summary>
        /// 戻り値5
        /// </summary>
        public static string ReturnValue5 { get; } = $@"戻り値の説明は以上だよ！
戻り値、引数はメソッドにおいて重要な役割を果たすから反復して覚えてね！
";
    }
}
