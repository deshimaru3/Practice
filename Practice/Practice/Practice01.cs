using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    /// <summary>
    /// LINQテスト問題
    /// 
    /// </summary>
    public class Practice01
    {
        /// <summary>
        /// 社員情報一覧
        /// </summary>
        private List<Employee> Employs = new List<Employee>
        {
            new Employee { Id = 1, Name = "AAAAA", JoinDate = new DateTime(2010, 4, 1), Money = 100 },
            new Employee { Id = 2, Name = "BBBBB", JoinDate = new DateTime(2018, 4, 1), Money = 150 },
            new Employee { Id = 3, Name = "CCCCC", JoinDate = new DateTime(2018, 4, 1), Money = 200 },
            new Employee { Id = 4, Name = "DDDDD", JoinDate = new DateTime(2018, 4, 1), Money = 250 },
            new Employee { Id = 5, Name = "EEEEE", JoinDate = new DateTime(2018, 9, 1), Money = 300 },
            new Employee { Id = 6, Name = "FFFFF", JoinDate = new DateTime(2019, 4, 1), Money = 350 },
            new Employee { Id = 7, Name = "GGGGG", JoinDate = new DateTime(2019, 4, 1), Money = 400 },
            new Employee { Id = 8, Name = "HHHHH", JoinDate = new DateTime(2019, 4, 1), Money = 450 },
            new Employee { Id = 9, Name = "IIIII", JoinDate = new DateTime(2019, 10, 1), Money = 500 },
        };

        /// <summary>
        /// 問題を解く際は、Linqを使用すること
        /// </summary>
        public void Practice001()
        {
            // 問題０１
            // 社員情報一覧から、「IDが1」の社員の名称を取得し、コンソールに出力こと
            // ヒント：LinqのWhere, Single　を使用すれば。。。

            // 問題０２
            // 社員情報一覧から、「名称（Name）がGGGGG」の社員の入社年月日を取得し、コンソールに出力すること
            // ヒント：LinqのWhere, Single　を使用すれば。。。

            // 問題０３
            // 社員情報一覧から、「入社年月日（JoinDate）が2019年10月1日」の社員の財産を取得し、コンソールに出力すること
            // ヒント：LinqのWhere, Single　を使用すれば。。。

            // 問題０４
            // 社員情報一覧から、「財産（Money）が400」の社員のIDを取得し、コンソールに出力すること
            // ヒント：LinqのWhere, Single　を使用すれば。。。

            // 問題０５
            // 社員情報一覧から、「財産が、300以上400未満」の社員の件数を取得し、コンソールに出力すること
            // ヒント：LinqのWhere, Count　を使用すれば。。。
        }

        /// <summary>
        /// 社員情報
        /// </summary>
        public class Employee
        {
            /// <summary>
            /// ID
            /// </summary>
            public int Id { get; set; }

            /// <summary>
            /// 名称
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// 入社年月日
            /// </summary>
            public DateTime JoinDate { get; set; }

            /// <summary>
            /// 財産
            /// </summary>
            public decimal Money { get; set; }
        }

    }
}
