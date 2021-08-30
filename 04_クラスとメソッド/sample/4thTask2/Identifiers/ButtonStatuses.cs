using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4thTask2.Identifiers
{
    /// <summary>
    /// ボタンステータス
    /// </summary>
    public enum ButtonStatuses
    {
        /// <summary>
        /// 次へ
        /// </summary>
        Next = 1,

        /// <summary>
        /// 前へ
        /// </summary>
        Back = 2,

        /// <summary>
        /// もう一度
        /// </summary>
        RePlain = 3,

        /// <summary>
        /// 次へ（カテゴリー）
        /// </summary>
        CategoryNext = 4,

        /// <summary>
        /// 前へ（カテゴリー）
        /// </summary>
        CategoryBack = 5,

        /// <summary>
        /// タブ
        /// </summary>
        Tab = 6,

        /// <summary>
        /// 説明へ進む
        /// </summary>
        GoExplain = 7,
    }
}
