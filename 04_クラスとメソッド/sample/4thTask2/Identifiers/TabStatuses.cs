using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thTask2.Identifiers
{
    /// <summary>
    /// 説明タブステータス
    /// </summary>
    public enum TabStatuses
    {
        /// <summary>
        /// 基礎
        /// </summary>
        tabBasic = -1,

        /// <summary>
        /// 基礎
        /// クラス
        /// </summary>
        tabBasicClass = -1,

        /// <summary>
        /// 基礎
        /// クラス
        /// 概念
        /// </summary>
        tabBasicClassConcept = 2,

        /// <summary>
        /// 基礎
        /// クラス
        /// コンストラクタ
        /// </summary>
        tabBasicClassConstructor = 16,

        /// <summary>
        /// 基礎
        /// クラス
        /// インスタンス化
        /// </summary>
        tabBasicClassInstantiation = 19,

        /// <summary>
        /// 基礎
        /// メソッド
        /// 概念
        /// </summary>
        tabBasicMethodConcept = 8,
        
        /// <summary>
        /// 基礎
        /// メソッド
        /// 引数
        /// </summary>
        tabBasicMethodArgument = 22,

        /// <summary>
        /// 基礎
        /// メソッド
        /// 戻り値
        /// </summary>
        tabBasicMethodReturnValue = 35,
    }
}
