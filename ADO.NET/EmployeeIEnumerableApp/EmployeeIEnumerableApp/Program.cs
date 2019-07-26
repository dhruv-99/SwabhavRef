using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeIEnumerableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                EMPNO = 7839,
                ENAME = "KING",
                JOB = "PRESIDENT",
                MGR = 0,
                HIREDATE = "17-NOV-81",
                SAL = 5000,
                COMM = 0,
                DEPTNO = 10
            };
            Employee employee2 = new Employee()
            {
                EMPNO = 7698,
                ENAME = "BLAKE",
                JOB = "MANAGER",
                MGR = 7839,
                HIREDATE = "1-MAY-81",
                SAL = 2850,
                COMM = 0,
                DEPTNO = 30
            };
            Employee employee3 = new Employee()
            {
                EMPNO = 7782,
                ENAME = "CLARK",
                JOB = "MANAGER",
                MGR = 7839,
                HIREDATE = "9-JUNE-81",
                SAL = 2450,
                COMM = 0,
                DEPTNO = 10
            };
            Employee employee4 = new Employee()
            {
                EMPNO = 7566,
                ENAME = "JONES",
                JOB = "MANAGER",
                MGR = 7398,
                HIREDATE = "2-APRIL-81",
                SAL = 2975,
                COMM = 0,
                DEPTNO = 20
            };
            Employee employee5 = new Employee()
            {
                EMPNO = 7654,
                ENAME = "MARTIN",
                JOB = "SALESMAN",
                MGR = 7698,
                HIREDATE = "28-SEP-81",
                SAL = 1250,
                COMM = 1400,
                DEPTNO = 30
            };
            Employee employee6 = new Employee()
            {
                EMPNO = 7499,
                ENAME = "ALLEN",
                JOB = "SALESMAN",
                MGR = 7698,
                HIREDATE = "20-FEB-81",
                SAL = 1600,
                COMM = 300,
                DEPTNO = 30
            };
            Employee employee7 = new Employee()
            {
                EMPNO = 7844,
                ENAME = "TURNER",
                JOB = "SALESMAN",
                MGR = 7698,
                HIREDATE = "8-SEP-81",
                SAL = 1500,
                COMM = 0,
                DEPTNO = 30
            };
            Employee employee8 = new Employee()
            {
                EMPNO = 7900,
                ENAME = "JAMES",
                JOB = "CLERK",
                MGR = 7698,
                HIREDATE = "3-DEC-81",
                SAL = 950,
                COMM = 0,
                DEPTNO = 30
            };
            Employee employee9 = new Employee()
            {
                EMPNO = 7521,
                ENAME = "WARD",
                JOB = "SALESMAN",
                MGR = 7698,
                HIREDATE = "22-FEB-81",
                SAL = 1250,
                COMM = 500,
                DEPTNO = 30
            };
            Employee employee10 = new Employee()
            {
                EMPNO = 7902,
                ENAME = "FORD",
                JOB = "ANALYST",
                MGR = 7566,
                HIREDATE = "3-DEC-81",
                SAL = 3000,
                COMM = 0,
                DEPTNO = 20
            };
            Employee employee11 = new Employee()
            {
                EMPNO = 7369,
                ENAME = "SMITH",
                JOB = "CLERK",
                MGR = 7902,
                HIREDATE = "17-DEC-80",
                SAL = 800,
                COMM = 0,
                DEPTNO = 20
            };
            Employee employee12 = new Employee()
            {
                EMPNO = 7788,
                ENAME = "SCOTT",
                JOB = "ANALYST",
                MGR = 7566,
                HIREDATE = "09-DEC-82",
                SAL = 3000,
                COMM = 0,
                DEPTNO = 20
            };
            Employee employee13 = new Employee()
            {
                EMPNO = 7876,
                ENAME = "ADAMS",
                JOB = "CLERK",
                MGR = 7788,
                HIREDATE = "12-JAN-83",
                SAL = 1100,
                COMM = 0,
                DEPTNO = 20
            };
            Employee employee14 = new Employee()
            {
                EMPNO = 7934,
                ENAME = "MILLER",
                JOB = "CLERK",
                MGR = 77828,
                HIREDATE = "23-JAN-82",
                SAL = 1300,
                COMM = 0,
                DEPTNO = 10
            };

            IList<Employee> employeeList = new List<Employee>()
            { employee1, employee2, employee3, employee4, employee5, employee6, employee7,
                employee8, employee9, employee10, employee11, employee12,
                employee13, employee14 };

            Department department1 = new Department()
            {
                DEPTNO = 10,
                DNAME = "ACCOUNTING",
                LOC = "NEW YORK"
            };

            Department department2 = new Department()
            {
                DEPTNO = 20,
                DNAME = "RESEARCH",
                LOC = "DALLAS"
            };

            Department department3 = new Department()
            {
                DEPTNO = 30,
                DNAME = "SALES",
                LOC = "CHICAGO"
            };

            Department department4 = new Department()
            {
                DEPTNO = 40,
                DNAME = "OPERATIONS",
                LOC = "BOSTON"
            };

            IList<Department> departments = new List<Department>() { department1,department2,department3,
            department4};

            //    Query1(employeeList);

            //    Query2(employeeList);

            //    Query3(employeeList);

            //     Query4(employeeList);

            //     Query5(employeeList);

            //     Query6(employeeList);

            //     Query7(employeeList);

            //      Query8(employeeList);

            //      Query9(employeeList);

            //      Query10(employeeList);

            //      Query11(employeeList);


            var joinQuery1 = employeeList
                .Join(departments, employee => employee.DEPTNO,
                department => department.DEPTNO, (employee, department) => new
                {
                    EmployeeName = employee.ENAME,
                    DepartmentNAME = department.DNAME
                });

            foreach (var emp in joinQuery1)
            {
                Console.WriteLine(emp.EmployeeName+" "+emp.DepartmentNAME);
            }




        }

        private static void Query11(IList<Employee> employeeList)
        {
            var query11 = employeeList
                .Select((employee) => new { employee.ENAME, EXP = (DateTime.Now.Year - Convert.ToDateTime(employee.HIREDATE).Year) });
            foreach (var employee in query11)
            {
                Console.WriteLine(employee.ENAME + " \t " + employee.EXP);
            }
        }

        private static void Query10(IList<Employee> employeeList)
        {
            var query10 = employeeList
                .OrderByDescending((employee) => employee.SAL)
                .Take(3);
            DiplayFullDetails(query10);
        }

        private static void Query9(IList<Employee> employeeList)
        {
            var query9 = employeeList
                            .Select((employee) => new { employee.DEPTNO }).Distinct();
            foreach (var employee in query9)
            {
                Console.WriteLine(employee.DEPTNO);
            }
        }

        private static void Query8(IList<Employee> employeeList)
        {
            var query8 = employeeList
                .Select((employee) => new { Lower = employee.ENAME.ToLower() });
            foreach (var employee in query8)
            {
                Console.WriteLine(employee.Lower);
            }
        }


        private static void Query7(IList<Employee> employeeList)
        {
            var query7 = employeeList
                            .Select((employee) => new { employee.ENAME, employee.SAL, CTC = (employee.COMM + employee.SAL * 12) });
            foreach (var employee in query7)
            {
                Console.WriteLine(employee.ENAME + " \t " + employee.SAL + " \t " + employee.CTC);
            }
        }

        private static void Query6(IList<Employee> employeeList)
        {
            var query6 = employeeList
                .Where((employee) => employee.COMM == 0);
            DiplayFullDetails(query6);
        }

        private static void Query5(IList<Employee> employeeList)
        {
            var query5 = employeeList
                            .Where((employee) => employee.JOB.Equals("MANAGER") && employee.DEPTNO == 10);
            DiplayFullDetails(query5);
        }

        private static void Query4(IList<Employee> employeeList)
        {
            var query4 = employeeList
             .Where((employee) => employee.JOB.Equals("MANAGER"))
             .Select((emp) => new { emp.ENAME });
            foreach (var employee in query4)
            {
                Console.WriteLine(employee.ENAME);
            }
        }

        private static void Query3(IList<Employee> employeeList)
        {
            var query3 = employeeList
                .Where((employee) => employee.DEPTNO == 10 || employee.DEPTNO == 20);
            DiplayFullDetails(query3);
        }

        private static void Query2(IList<Employee> employeeList)
        {
            var query2 = employeeList
                .Where((employee) => employee.DEPTNO == 10);
            DiplayFullDetails(query2);
        }

        private static void Query1(IList<Employee> employeeList)
        {
            var query1 = employeeList
                .OrderBy((employee) => employee.ENAME);
            Console.WriteLine("EMPNO \t ENAME \t JOB \t MGR \t HIREDATE \t SAL \t COMM \t DEPTNO");
            DiplayFullDetails(query1);
        }

        private static void DiplayFullDetails(IEnumerable<Employee> query)
        {
            foreach (var employee in query)
            {
                Console.WriteLine(employee.EMPNO + " \t " + employee.ENAME + " \t " + employee.JOB + " \t " + employee.MGR + " \t " + employee.HIREDATE + " \t "
                   + employee.SAL + " \t " + employee.COMM + " \t " + employee.DEPTNO);
            }
        }
    }
}
