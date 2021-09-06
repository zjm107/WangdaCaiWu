using System.Data;
using Tiger.Tools;
namespace WangDaDll.SalaryServer
{


    partial class SalaryDataSet
    {
        partial class VW_AllBusinessSalaryYearDataTable
        {
        }

        public SysTools DBHelper = new SysTools();

        /// <summary>
        /// 获取业务员指定月份的业绩
        /// </summary>
        /// <param name="businessID">业务员ID</param>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        public void GetBusinessSum(string businessID, int year, int month)
        {
            DataSet dst = DBHelper.WangDaSer.GetBusinessSum(businessID, year, month);
            DataManager.ImpDataSet(dst.Tables[0], this.tableTW_SalarySum);
        }

        /// <summary>
        /// 获取业务员指定月份的业绩
        /// </summary>
        /// <param name="businessID">业务员ID</param>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        public void GetBusinessSumCZB(string businessID, int year, int month)
        {
            DataSet dst = DBHelper.WangDaSer.GetBusinessSumCZB2021(businessID, year, month);
            DataManager.ImpDataSet(dst.Tables[0], this.tableTW_SalarySum);
        }


        /// <summary>
        /// 获取业务员指定月份的业绩
        /// </summary>
        /// <param name="businessID">业务员ID</param>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        public void GetBusinessSumYCX(string businessID, int year, int month)
        {
            DataSet dst = DBHelper.WangDaSer.GetBusinessSumYCX2021(businessID, year, month);
            DataManager.ImpDataSet(dst.Tables[0], this.tableTW_SalarySum);
        }

        /// <summary>
        /// 获取全体业务员业绩，包括主管的业绩
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        public void GetAllBusinessSum(int year, int month, string userManagerID, string userName)
        {
            DataSet dst = DBHelper.WangDaSer.GetAllBusinessSum(year, month, userManagerID, userName);
            DataManager.ImpDataSet(dst.Tables[0], VW_AllBusinessSalary);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        /// <param name="userName"></param>
        public void GetAllBusinessSumZC(int year, int month, string userManagerID, string userName)
        {
            DataSet dst = DBHelper.WangDaSer.GetAllBusinessSumZC(year, month, userManagerID, userName);
            DataManager.ImpDataSet(dst.Tables[0], VW_AllBusinessSalary);
        }

        /// <summary>
        /// 注册部业绩2021
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        /// <param name="userName"></param>
        public void GetAllBusinessSumZC2021(int year, int month, string userManagerID, string userName)
        {
            DataSet dst = DBHelper.WangDaSer.GetAllBusinessSumZC2021(year, month, userManagerID, userName);
            DataManager.ImpDataSet(dst.Tables[0], VW_AllBusinessSalary);

          //  AddPerformance();  //计算绩效
        }


        /// <summary>
        /// 获取所有业务员业绩，加绩效工资
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        /// <param name="userName"></param>
        public void GetAllBusinessSum2021(int year, int month, string userManagerID, string userName)
        {
            DataSet dst = DBHelper.WangDaSer.GetAllBusinessSum2021(year, month, userManagerID, userName);
            DataManager.ImpDataSet(dst.Tables[0], VW_AllBusinessSalary);
            AddPerformance();  //计算绩效
        }

        /// <summary>
        /// 计算业务员的绩效工资
        /// </summary>
        public void AddPerformance()
        {
            decimal tc = (decimal)0.08;
            foreach (VW_AllBusinessSalaryRow row in VW_AllBusinessSalary.Rows)
            {
                decimal sumprice = row.做账收款额 + row.注册利润 + row.成长版 + row.其他一次性业务;
                if (sumprice >= 20000 && sumprice < 30000)
                {
                    row.绩效 = sumprice * tc;

                }
                else
                    if (sumprice >= 30000 && sumprice <= 40000)
                {
                    row.绩效 = sumprice * tc + 500;
                }
                else if (sumprice > 40000 && sumprice <= 50000)
                {
                    row.绩效 = sumprice * tc + 1000;
                }
                else if (sumprice > 50000)
                {
                    row.绩效 = sumprice * tc + 1800;
                }
                else
                {
                    row.绩效 = 0;
                }


            }
        }

        public void GetAllBusinessSumOther(int year, int month, string userManagerID, string userName,string deptId)
        {
            DataSet dst = DBHelper.WangDaSer.GetAllBusinessSumOther(year, month, userManagerID, userName,deptId);
            DataManager.ImpDataSet(dst.Tables[0], VW_AllBusinessSalary);
        }

        /// <summary>
        /// 计算绩效工资
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        /// <param name="userName"></param>
        public void GetAllBusinessSumOther2021(int year, int month, string userManagerID, string userName,string deptId)
        {
            DataSet dst = DBHelper.WangDaSer.GetAllBusinessSumOther2021(year, month, userManagerID, userName,deptId);
            DataManager.ImpDataSet(dst.Tables[0], VW_AllBusinessSalary);
           // AddPerformance();//计算绩效
        }



        /// <summary>
        /// 获取一个人的业务提成
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userManagerID"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public decimal GetAllBusinessSumValue(int year, int month, string userManagerID, string userName,string deptid)
        {
            DataSet dst = DBHelper.WangDaSer.GetAllBusinessSumOther2021(year, month, userManagerID, userName,deptid);
            DataManager.ImpDataSet(dst.Tables[0], VW_AllBusinessSalary);
            decimal sumValue = 0;
            var rows = VW_AllBusinessSalary.Select(string.Format("员工='{0}'", userName));
            if (rows.Length > 0)
            {

                sumValue = decimal.Parse(rows[0]["做账提成"].ToString());
            }

            else
                sumValue = 0;
            return sumValue;
        }

        /// <summary>
        /// 获取业务部的全部业绩数据
        /// </summary>
        /// <param name="businessID"></param>
        /// <returns></returns>
        public void GetBussinessManagerDept(string businessID)
        {
            DataSet dst = DBHelper.WangDaSer.GetBussinessManagerDept(businessID);
            DataManager.ImpDataSet(dst.Tables[0], this.tableTW_SalarySum);
        }

        /// <summary>
        /// 获取一个人的上年业绩
        /// </summary>
        /// <param name="Year"></param>
        /// <param name="businessManID"></param>
        public void GetBussinessSumByLastYear(int year, string businessManID)
        {
            DataSet dst = DBHelper.WangDaSer.GetBussinessSumByYear(year, businessManID);
            DataManager.ImpDataSet(dst.Tables[0], this.tableTW_SalarySum);
        }

        /// <summary>
        /// 获取业务部的上年业绩明细
        /// </summary>
        /// <param name="year"></param>
        public void GetBusinessLastYear(int year, string userName)
        {
            DataSet dst = DBHelper.WangDaSer.GetBusinessLastYear(year, userName);
            DataManager.ImpDataSet(dst.Tables[0], this.tableVW_AllBusinessSalaryYear);

        }

        /// <summary>
        /// 获取注册业绩
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public void GetRegSum(int year, int month, string userName)
        {
            DataSet dst = DBHelper.WangDaSer.GetRegSum(year, month, userName);
            DataManager.ImpDataSet(dst.Tables[0], this.VW_AllBusinessSalary);
        }
        /// <summary>
        /// 获取注册明细
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userID"></param>
        public void GetRegSumDetail(int year, int month, string userID)
        {
            DataSet dst = DBHelper.WangDaSer.GetRegSumDetail(year, month, userID);
            DataManager.ImpDataSet(dst.Tables["TW_SalarySum"], this.tableTW_SalarySum);

            DataManager.ImpDataSet(dst.Tables["TW_SalarySumReg"], this.TW_SalarySumReg);

        }

        /// <summary>
        /// 获取做账会计信息
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        public void GetAccountantSum(int year, int month, string userName,string deptId)
        {
            DataSet dst = DBHelper.WangDaSer.GetAccountantSum(year, month, userName, deptId);
            DataManager.ImpDataSet(dst.Tables["VW_AllAccountantSalary"], this.VW_AllAccountantSalary);

        }

        public void GetAccountantSum2021(int year, int month, string userName,string deptId)
        {
            DataSet dst = DBHelper.WangDaSer.GetAccountantSum2021(year, month, userName, deptId);
            DataManager.ImpDataSet(dst.Tables["VW_AllAccountantSalary"], this.VW_AllAccountantSalary);

        }






        /// <summary>
        /// 获取做账明细信息
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="userID"></param>
        public void GetAccountantSumDetail(int year, int month, string userID)
        {
            DataSet dst = DBHelper.WangDaSer.GetAccountantSumDetail(year, month, userID);
            DataManager.ImpDataSet(dst.Tables["VW_AllAccountantSalaryDetail"], this.tableVW_AllAccountantSalaryDetail);
            DataManager.ImpDataSet(dst.Tables["VW_AllAccountantSalaryDetailZ"], this.VW_AllAccountantSalaryDetailZ);
            DataManager.ImpDataSet(dst.Tables["VW_AllAccountantSalaryTeacher"], this.VW_AllAccountantSalaryTeacher);
            DataManager.ImpDataSet(dst.Tables["VW_AllAccountantSalaryUser"], this.VW_AllAccountantSalaryUser);

        }


    }

}
